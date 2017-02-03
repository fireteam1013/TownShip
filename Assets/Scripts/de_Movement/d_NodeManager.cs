using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_NodeManager : MonoBehaviour {

    public d_Node[,] nodeArray;

    
    public void configureNodes(int x, int y)
    {
        nodeArray = new d_Node[x, y];
        for (int u = 0; u < x; u++)
        {
            for (int v = 0; v < y; v++)
            {
                nodeArray[u, v] = new d_Node();
            }
        }
    }
    
}
