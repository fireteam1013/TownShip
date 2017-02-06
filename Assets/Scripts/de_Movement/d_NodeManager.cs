using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_NodeManager : MonoBehaviour {

    GameObject overlayManager;
    d_OverlayManager OManager;


    GameObject mapMaker;
    d_MapMaker mMaker;


    public d_Node[,] nodeArray;

    void Start()
    {
        overlayManager = GameObject.Find("OverlayManager");
        OManager = overlayManager.GetComponent<d_OverlayManager>();
        mapMaker = GameObject.Find("MapMaker");
        mMaker = mapMaker.GetComponent<d_MapMaker>();
    }

     
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

    public void CullOverlay()
    {
        foreach(GameObject move in OManager.moveTiles)
        {
            move.SetActive(false);
            move.transform.position = new Vector2(-10, -10);
        }
    }

    public void UnitOverlay(Vector2 unitPos, int movement)
    {
        int x = Mathf.RoundToInt(unitPos.x);
        int y = Mathf.RoundToInt(unitPos.y);
    }
}
