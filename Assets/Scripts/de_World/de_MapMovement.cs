using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de_MapMovement : MonoBehaviour {

    float inputX;
    float inputY;

    bool fast;

    float normalSpeed = 4.0f;
    float fastSpeed = 8.0f;

    void Update()
    {
        InputMotor();
    }

    void InputMotor()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            fast = true;
        }
        else
        {
            fast = false;
        }
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }


    void FixedUpdate()
    {
        if(fast == false)
        {
            transform.position += new Vector3(inputX, inputY, 0).normalized * normalSpeed * Time.deltaTime;
        }else
        {
            transform.position += new Vector3(inputX, inputY, 0).normalized * fastSpeed * Time.deltaTime;
        }
    }
}
