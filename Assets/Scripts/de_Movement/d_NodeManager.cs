using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_NodeManager : MonoBehaviour {

    public Node[,] nodeArray;
    int mapSizeX;
    int mapSizeY;

    public void configureNodes(int x, int y)
    {
        mapSizeX = x;
        mapSizeY = y;
        ConfigureArray();
    }

    void ConfigureArray()
    {
        nodeArray = new Node[mapSizeX, mapSizeY];
    }
}
