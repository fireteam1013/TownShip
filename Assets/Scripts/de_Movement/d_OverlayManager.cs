using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_OverlayManager : MonoBehaviour {

	[SerializeField]
    private GameObject moveOverlay;
    [SerializeField]
    private GameObject attackOverlay;

    public List<GameObject> moveTiles = new List<GameObject>();
    public List<GameObject> attackTiles = new List<GameObject>();

    GameObject overlayHolder;

    int numberOfMove = 220; //10
    int numberOfAttack = 64;  //16 tiles - 6 attack range


    void Start()
    {
        overlayHolder = new GameObject();
        overlayHolder.name = "OverlayHolder";
        overlayHolder.transform.position = new Vector2(-10, -10);

        for (int i = 0; i < numberOfMove; i++)
        {
            moveTiles.Add(Instantiate(moveOverlay, overlayHolder.transform.position, transform.rotation, overlayHolder.transform));
            
        }
        for (int i = 0; i < numberOfAttack; i++)
        {
            attackTiles.Add(Instantiate(attackOverlay, overlayHolder.transform.position, transform.rotation, overlayHolder.transform));
        }
    }

    public void MoveTiles()
    {

    }
}
