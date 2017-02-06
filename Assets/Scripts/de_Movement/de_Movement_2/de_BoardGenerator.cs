using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de_BoardGenerator : MonoBehaviour {

    [SerializeField]
    private int mapSizeX;
    [SerializeField]
    private int mapSizeY;

    GameObject tileHolder;

    public de_Node[,] nodeArray;
    public int[,] mapArray;
    public GameObject[,] tileArray;

    public GameObject tile;
    public Sprite[] tileTypes;
    void Start()
    {
        nodeArray = new de_Node[mapSizeX, mapSizeY];
        mapArray = new int[mapSizeX, mapSizeY];
        tileArray = new GameObject[mapSizeX, mapSizeY];
        ConfigureTileHolder();
        InstantiateArrays();
        ModMapArray();
        SetTileImage();
    }

    void ConfigureTileHolder()
    {
        tileHolder = new GameObject();
        tileHolder.name = "TileHolder";
    }

    void InstantiateArrays()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                mapArray[x, y] = 0;

                tileArray[x, y] = Instantiate(tile, new Vector2(x, y), transform.rotation, tileHolder.transform);
                tileArray[x, y].name = "Tile_" + x + "_" + y;

                nodeArray[x, y] = new de_Node();
                nodeArray[x, y].X = x;
                nodeArray[x, y].Y = y;
            }
        }
    }

    void ModMapArray()
    {
        mapArray[2, 2] = 1;
        mapArray[4, 6] = 1;
        mapArray[6, 4] = 1;
    }

    void SetTileImage()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                nodeArray[x, y].MovementCost = mapArray[x, y];
                tileArray[x, y].GetComponent<SpriteRenderer>().sprite = tileTypes[mapArray[x, y]];
            }
        }
    }

}
