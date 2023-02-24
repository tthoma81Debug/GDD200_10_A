using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 MoveRight;
    Vector3 MoveLeft;
    Vector3 MoveUp;
    Vector3 MoveDown;

    Vector3 finalLeft;
    Vector3 finalRight;
    Vector3 finalUp;
    Vector3 finalDown;
    int speed = 15;

    void Start()
    {
        Debug.Log("Hello world. This is start method");
        MoveRight = new Vector3(1, 0, 0);
        MoveDown = new Vector3(0, -1, 0);
        MoveUp = new Vector3(0, 1, 0);
        MoveLeft = new Vector3(-1, 0, 0);
        //finalRight = MoveRight;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello world. This is update method");
        finalRight = (MoveRight * Time.deltaTime) * speed;
        finalLeft = (MoveLeft * Time.deltaTime) * speed;
        finalUp = (MoveUp * Time.deltaTime) * speed;
        finalDown = (MoveDown * Time.deltaTime) * speed;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow detected.");
            transform.Translate(finalRight);
        }
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow Detected");
            transform.Translate(finalLeft);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow detected");
            transform.Translate(finalDown);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow Detected");
            transform.Translate(finalUp);
        }

    }
}
