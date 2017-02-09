using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de_WorldMaker : MonoBehaviour {

    [SerializeField]
    private int mapSizeX;
    [SerializeField]
    private int mapSizeY;

    private int[,] mapArray;
    private GameObject mapHolder;

    int totalTiles;
    int mountainCount;
    int forestCount;
    int waterCount;

    void Start()
    {
        mapArray = new int[mapSizeX, mapSizeY];
        mapHolder = new GameObject();
        mapHolder.name = "MapHolder";
        MapCalculations();
        ConfigureArray();
    }

    void MapCalculations()
    {

    }

    void ConfigureArray()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                mapArray[x, y] = 0;
            }
        }
    }


}
