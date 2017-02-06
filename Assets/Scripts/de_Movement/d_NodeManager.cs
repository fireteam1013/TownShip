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
        //int i = 0;



        //This doesn't work
        //for (int nX1 = x-movement; nX1 <= x+movement; nX1++)
        //{
        //    for (int nY1 = y-movement; nY1 <= y+movement; nY1++)
        //    {
        //        if(nX1 >=0 && nX1 < 10 && nY1 >=0 && nY1 < 10)
        //        {
        //            int nX = nX1 - x;
        //            int nY = nY1 - y;
        //            int mC = nodeArray[nX1, nY1].MCost;
        //            if (nX < 0)
        //            {
        //                nX *= -1;
        //            }
        //            if (nY < 0)
        //            {
        //                nY *= -1;
        //            }
        //            nodeArray[nX1, nY1].FScore = nX + nY + mC;
        //            if (nodeArray[nX1, nY1].FScore <= movement)
        //            {
        //                OManager.moveTiles[i].SetActive(true);
        //                OManager.moveTiles[i].transform.position = nodeArray[nX1, nY1].Pos;
        //                i++;
        //            }
        //        }
                
        //    }
        //}



        for (int ux = 0; ux < 10; ux++)
        {
            for (int uy = 0; uy < 10; uy++)
            {
                mMaker.tileArray[ux,uy].GetComponent<d_Tile>().f = nodeArray[ux, uy].FScore;

            }
        }
    }
}
