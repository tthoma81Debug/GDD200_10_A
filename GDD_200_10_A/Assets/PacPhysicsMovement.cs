using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacPhysicsMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D pacPhysics;
    Vector3 rightForce;
    Vector3 upForce;
    Vector3 leftForce;
    Vector3 finalRightForce;
    Vector3 finalLeftForce;

    public bool canJump;
    float gravitationalForces;

    void Start()
    {
        pacPhysics = GetComponent<Rigidbody2D>();
        rightForce = new Vector3(2, 0, 0);
        upForce = new Vector3(0, 17, 0);
        leftForce = new Vector3(-2, 0, 0);
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        gravitationalForces = pacPhysics.velocity.y;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow detected.");
            finalRightForce = new Vector3(rightForce.x, gravitationalForces, 0);

            //pacPhysics.AddForce(rightForce);
            pacPhysics.velocity = finalRightForce;
            
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow Detected");

            finalLeftForce = new Vector3(leftForce.x, gravitationalForces, 0);
            pacPhysics.velocity = finalLeftForce;
            
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow detected");
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //only returns true on first frame
        {
            if(canJump == true)
            {
                Debug.Log("Jumping!");
                canJump = false;
                pacPhysics.AddForce(upForce, ForceMode2D.Impulse);
            }
            else
            {
                Debug.Log("trying to jump, but can't :)");
            }
           

            
            
            
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ran into" + collision.gameObject.name);
        if(collision.gameObject.name == "groundTiles")
        {
            canJump = true;
        }
    }
}
