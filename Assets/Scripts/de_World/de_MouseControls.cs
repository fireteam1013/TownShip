using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de_MouseControls : MonoBehaviour {

    Ray mousePosition;
    RaycastHit mouseRayHit;
    Vector3 mouseHit;

    void Update()
    {
        mousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast (mousePosition, out mouseRayHit))
            {
            Vector3 _mousePos = new Vector3(Mathf.RoundToInt(mouseRayHit.point.x), Mathf.RoundToInt(mouseRayHit.point.y), Mathf.RoundToInt(mouseRayHit.point.z));
            mouseHit = _mousePos;
            
            }
    }
}
