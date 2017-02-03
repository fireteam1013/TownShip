using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_Tile : MonoBehaviour {


    d_Node node;
    Vector2 p;


    public void setNode(d_Node x)
    {
        node = x;
        p = Camera.main.WorldToScreenPoint(node.Pos);
    }


    void OnGUI()
    {
        GUIStyle tileDebug = new GUIStyle();
        tileDebug.fontSize = 8;
        
        GUI.Label(new Rect(p.x - 30, Screen.height -p.y -30, 80, 20), node.Pos.ToString(), tileDebug);
        GUI.Label(new Rect(p.x - 30, Screen.height - p.y - 20, 80, 20), "F = ", tileDebug);
        GUI.Label(new Rect(p.x - 30, Screen.height - p.y, 80, 20), "G = ", tileDebug);
        GUI.Label(new Rect(p.x, Screen.height - p.y, 80, 20), "H = ", tileDebug);
    }
}
