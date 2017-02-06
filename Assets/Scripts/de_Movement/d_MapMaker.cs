using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent (typeof(d_NodeManager))]
public class d_MapMaker : MonoBehaviour {

    d_NodeManager d_NManager;
    int mapSizeX = 10;
    int mapSizeY = 10;
    int[,] mapArray;
    public GameObject[,] tileArray;
    public Sprite[] tileTypes;

    void Start()
    {
        d_NManager = GetComponent<d_NodeManager>();
        d_NManager.configureNodes(mapSizeX, mapSizeY);
        ConfigureArray();
    }

    void ConfigureArray()
    {
        //Configure mapArray
        mapArray = new int[mapSizeX, mapSizeY];
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                mapArray[x, y] = 0;
            }
        }
        mapArray[4, 4] = 1;

        ConfigureNodes();


        //Configure Tiles
        tileArray = new GameObject[mapSizeX, mapSizeY];
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                GameObject tile = new GameObject();
                tileArray[x, y] = tile;
                tile.AddComponent<SpriteRenderer>();
                tile.GetComponent<SpriteRenderer>().sprite = tileTypes[mapArray[x, y]];
                tile.transform.position = new Vector2(x, y);
                tile.AddComponent<d_Tile>();
                tile.GetComponent<d_Tile>().setNode(d_NManager.nodeArray[x, y]);
            }
        }




        //This sets the movement of each node as the mapArray
        //TODO: Find another way of doing this as the tiles(graphics) need to use the information stored in the mapArray
        
    }

    void ConfigureNodes()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                d_NManager.nodeArray[x, y].MCost = mapArray[x, y];
                d_NManager.nodeArray[x, y].Pos = new Vector2(x, y);
            }
        }
    }



}
