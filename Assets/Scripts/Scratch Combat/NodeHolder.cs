using System.Collections;
using UnityEngine;

/// <summary>==================================================
/// Description Here
/// </summary>=================================================

public class NodeHolder : MonoBehaviour
{
    public Node[,] nodeArray;
    int mapSizeX;
    int mapSizeY;


    void Start()
    {
        nodeArray = new Node[mapSizeX, mapSizeY];   
    }
}