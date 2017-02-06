using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_Unit : MonoBehaviour {

    GameObject mapController;
    d_NodeManager nodeManager;

    int movement =3;

    public int Movement
    {
        get
        {
            return movement;
        }

        set
        {
            movement = value;
        }
    }
    List<Vector2> whereCanMove = new List<Vector2>();


    void Start()
    {
        //TODO:Change this name
        mapController = GameObject.Find("MapMaker");
        nodeManager = mapController.GetComponent<d_NodeManager>();
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P is pressed");
            SetMovement();
        }
        Vector2 _unitPosition = gameObject.transform.position;
        Vector2 _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(_mousePosition == _unitPosition && Input.GetMouseButtonDown(0))
        {
            SetMovement();
            Debug.Log("Called");
            //Get the nodes of movement;
            //Move the overlays to those nodes;
        }
    }

    public void SetMovement()
    {
        Vector2 _thisPos = gameObject.transform.position;
        nodeManager.CullOverlay();
        nodeManager.UnitOverlay(_thisPos, movement);
    }
}
