using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class de_MapMakerOld : MonoBehaviour {

    public de_Nodes[,] nodes;

    public TileType[] tileTypes;
    public GameObject overlayMove;
    public GameObject overlayAttack;


    public static int[,] tiles;
    public int mapSizeX;
    public int mapSizeY;

    //--------------------------------------------------------------------------------------------------

    void Start()
    {
        GenerateMapData();
        GenerateMapVisuals();

        GenerateNodes();
    }

    //--------------------------------------------------------------------------------------------------

    void GenerateMapData()
    {
        int totalTiles = mapSizeX * mapSizeY;
        double minForestTilePercent = 0.10; // TODO: Move to a config setting (for this map type)
        double maxForestTilePercent = 0.40; // TODO: Move to a config setting (for this map type)
        double minMountainTilePercent = 0.10; // TODO: Move to a config setting (for this map type)
        double maxMountainTilePercent = 0.20; // TODO: Move to a config setting (for this map type)

        // TODO: These should be in some library or something
        int grassTileTypeId = 0;
        int forestTileTypeId = 1;
        int mountainTileTypeId = 2;
        int foothillTileTypeId = 3;

        // Initialize with all grass
        tiles = new int[mapSizeX, mapSizeY];
        System.Random rnd;

        // Add patches of forest
        int minForestTileCount = (int)Math.Ceiling(totalTiles * minForestTilePercent);
        int maxForestTileCount = (int)Math.Ceiling(totalTiles * maxForestTilePercent);

        int forestSeed = (int)DateTime.Now.Ticks; // TODO: Allow this to be specified so we can reproduce maps (e.g. going back to a previous location) 
        Debug.Log("Forest Seed: " + forestSeed);
        rnd = new System.Random(forestSeed);
        int totalForestTileCount = 0;
        int targetForestTileCount = rnd.Next(minForestTileCount, maxForestTileCount);
        Queue<int[]> stands = new Queue<int[]>();
        while (totalForestTileCount < targetForestTileCount)
        {
            if (stands.Count == 0)
            {
                stands.Enqueue(new int[2] {
                    rnd.Next(0, mapSizeX - 1),
                    rnd.Next(0, mapSizeY - 1),
                });
            }
            int[] stand = stands.Dequeue();
            int x = stand[0];
            int y = stand[1];
            ++totalForestTileCount;
            tiles[x, y] = forestTileTypeId;

            for (int i = -1; i <= 1; ++i)
            {
                for (int j = -1; j <= 1; ++j)
                {
                    if (x + i >= 0 && x + i < mapSizeX &&
                        y + j >= 0 && y + j < mapSizeY
                    )
                    {
                        if (tiles[x + i, y + j] != forestTileTypeId)
                        {
                            ++totalForestTileCount;
                            tiles[x + i, y + j] = forestTileTypeId;
                            if (rnd.NextDouble() < 0.25)
                            { // Occasionally expand the forest
                                stands.Enqueue(new int[2] { x + i, y + j });
                            }
                        }
                    }
                }
            }
        }

        // Add mountain ranges
        // We pick a point, draw a line across the map across that point and then add mountains along that line
        int minMountainTileCount = (int)Math.Ceiling(totalTiles * minMountainTilePercent);
        int maxMountainTileCount = (int)Math.Ceiling(totalTiles * maxMountainTilePercent);

        int mountainSeed = (int)DateTime.Now.Ticks; // TODO: Allow this to be specified so we can reproduce maps (e.g. going back to a previous location) 
        Debug.Log("Mountain Seed: " + mountainSeed);
        rnd = new System.Random(mountainSeed);
        int totalMountainTileCount = 0;
        int targetMountainTileCount = rnd.Next(minMountainTileCount, maxMountainTileCount);
        int[] mainPeak = new int[2];
        Queue<int[]> peaks = new Queue<int[]>();
        double slope = 0.0;
        double intercept = 0.0;
        while (totalMountainTileCount < targetMountainTileCount)
        {
            if (peaks.Count == 0)
            {
                mainPeak = new int[2] {
                    rnd.Next(0, mapSizeX - 1),
                    rnd.Next(0, mapSizeY - 1),
                };
                peaks.Enqueue(mainPeak);
                slope = rnd.NextDouble() * ((rnd.NextDouble() < 0.5) ? -1 : 1);
                intercept = mainPeak[1] - slope * mainPeak[0];
            }
            int[] peak = peaks.Dequeue();
            int x = peak[0];
            int y = peak[1];
            ++totalMountainTileCount;
            tiles[x, y] = mountainTileTypeId;

            // We want to select one tile to the left/bottom and one tile to the right/top.
            // Tiles closer to the line have a greater chance of being selected
            // Expand to the left/bottom first
            int[,] neighborhood = new int[4, 2] {
                {x-1,y-1},
                {x-1,y+0},
                {x-1,y+1},
                {x+0,y-1}
            };
            totalMountainTileCount = mountainTileSelection(neighborhood, mainPeak, peaks, slope, intercept, rnd, grassTileTypeId, mountainTileTypeId, forestTileTypeId, foothillTileTypeId, totalMountainTileCount);

            // Then expand to the right
            neighborhood = new int[4, 2] {
                {x+1,y-1},
                {x+1,y+0},
                {x+1,y+1},
                {x+0,y+1}
            };
            totalMountainTileCount = mountainTileSelection(neighborhood, mainPeak, peaks, slope, intercept, rnd, grassTileTypeId, mountainTileTypeId, forestTileTypeId, foothillTileTypeId, totalMountainTileCount);
        }
    }

    private bool changeTileType(int x, int y, int tileType)
    {
        bool changed = tiles[x, y] == tileType;
        tiles[x, y] = tileType;
        return changed;
    }

    private int mountainTileSelection(int[,] neighborhood, int[] mainPeak, Queue<int[]> peaks, double slope, double intercept, System.Random rnd, int grassTileTypeId, int mountainTileTypeId, int forestTileTypeId, int foothillTileTypeId, int totalMountainTileCount)
    {
        double[] rouletteWheel = new double[4];
        double d = 0;

        // Find the distance from the desired slope line to the neighborhood tiles
        for (int i = 0; i < 4; ++i)
        {
            if (neighborhood[i, 0] >= 0 && neighborhood[i, 0] < mapSizeX &&
                neighborhood[i, 1] >= 0 && neighborhood[i, 1] < mapSizeY
            )
            {
                if (tiles[neighborhood[i, 0], neighborhood[i, 1]] != mountainTileTypeId)
                {
                    double dy = Math.Abs((neighborhood[i, 1]) - (slope * (neighborhood[i, 0]) + intercept)); // distance of this tile away from the desired line
                    dy = Math.Min(dy > 0 ? 1 / dy : 16, 16);
                    d += Math.Abs(dy);
                    rouletteWheel[i] = dy;
                }
            }
        }

        // Choose the terrain for each tile in the neighborhood
        double rouletteSelection = rnd.NextDouble() * d + 1;
        for (int i = 0; i < 4; ++i)
        {
            if (neighborhood[i, 0] >= 0 && neighborhood[i, 0] < mapSizeX &&
                neighborhood[i, 1] >= 0 && neighborhood[i, 1] < mapSizeY
            )
            {
                rouletteSelection -= rouletteWheel[i];
                if (rouletteSelection <= 0)
                {
                    // This tile becomes a peak
                    if (tiles[neighborhood[i, 0], neighborhood[i, 1]] != mountainTileTypeId)
                    {
                        peaks.Enqueue(new int[2] { neighborhood[i, 0], neighborhood[i, 1] });
                    }
                    rouletteSelection = Double.MaxValue;
                }
                else if (rnd.NextDouble() < 0.5 && tiles[neighborhood[i, 0], neighborhood[i, 1]] == grassTileTypeId)
                {
                    // Add foothills around the peaks
                    changeTileType(neighborhood[i, 0], neighborhood[i, 1], foothillTileTypeId);
                }
                else if (rnd.NextDouble() < 0.75 && tiles[neighborhood[i, 0], neighborhood[i, 1]] == grassTileTypeId)
                {
                    // Mountains tend to be surrounded by forests, so we add some here
                    changeTileType(neighborhood[i, 0], neighborhood[i, 1], forestTileTypeId);
                }
            }
        }

        return totalMountainTileCount;
    }

    void GenerateMapVisuals()
    {
        GameObject mapHolder = new GameObject();
        mapHolder.name = "MapHolder";
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                TileType tt = tileTypes[tiles[x, y]];
                float hx = x;
                float hz = y;
                GameObject go = (GameObject)Instantiate(tt.tileVisualPrefab, new Vector3(hx, hz, 0), Quaternion.identity, mapHolder.transform);
                GameObject ov = Instantiate(overlayMove, new Vector3(hx, hz, 0), transform.rotation, go.transform);
                ov.SetActive(false);
            }
        }
    }





    void GenerateNodes()
    {
        nodes = new de_Nodes[mapSizeX, mapSizeY];
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                //Create a new node in the array
                nodes[x, y] = new de_Nodes();
                //Set the node movement cost to the tile value
                //TODO: this needs to change, but later
                nodes[x, y].movementCost = tiles[x, y];
            }
        }
    }
}