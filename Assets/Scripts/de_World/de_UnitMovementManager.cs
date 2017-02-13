using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de_UnitMovementManager : MonoBehaviour {

    de_MapMakerOld Map;


    GameObject mouseOverObject;

    List<de_Nodes> Queue = new List<de_Nodes>();
    List<de_Nodes> OpenList = new List<de_Nodes>();
    List<de_Nodes> ClosedList = new List<de_Nodes>();


    void Start()
    {
        Map = GameObject.Find("WorldMaker").GetComponent<de_MapMakerOld>();
    }

    public void SetUnit(GameObject x)
    {
        mouseOverObject = x;
    }

    void checkNodes()
    {
        int _x = Mathf.RoundToInt(mouseOverObject.transform.position.x);
        int _y = Mathf.RoundToInt(mouseOverObject.transform.position.y);

        Queue.Add(Map.nodes[_x, _y]);
    }


}
