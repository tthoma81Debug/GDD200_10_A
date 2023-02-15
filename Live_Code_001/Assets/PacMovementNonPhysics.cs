using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMovementNonPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 rightMovement;
    Vector3 rightMovementScaled;
    int speed;
    void Start()
    {
        Debug.Log("Start method");
        rightMovement = new Vector3(1, 0, 0);
        speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        rightMovementScaled = (rightMovement * Time.deltaTime) * speed;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow key pressed");
            transform.Translate(rightMovementScaled);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left arrow pressed");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("up arrow pressed");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("down arrow pressed");
        }


        //Debug.Log("Update method");
    }
}
