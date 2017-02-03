using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(d_NodeManager))]
public class d_MapMaker : MonoBehaviour {

    d_NodeManager d_NManager;
    int mapSizeX = 10;
    int mapSizeY = 10;
    int[,] mapArray;

    void Start()
    {
        d_NManager = GetComponent<d_NodeManager>();
        ConfigureArray();
    }

    void ConfigureArray()
    {
        mapArray = new int[mapSizeX, mapSizeY];
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                mapArray[x, y] = 1;
            }
        }
        mapArray[4, 4] = 2;


        d_NManager.configureNodes(mapSizeX, mapSizeY);

        //This sets the movement of each node as the mapArray
        //TODO: Find another way of doing this as the tiles(graphics) need to use the information stored in the mapArray
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                d_NManager.nodeArray[x, y].MovementCost = mapArray[x, y];
            }
        }
    }




}
