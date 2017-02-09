
using UnityEngine;

public class d_CameraMovement : MonoBehaviour {

    float inputX;
    float inputY;
    float speed = .1f;

    void FixedUpdate()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(inputX, inputY, 0).normalized * speed;
    }

}
