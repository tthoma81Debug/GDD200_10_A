using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMovementPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D pacmanPhysicsEngine;
    Vector3 rightVelocity;
    Vector3 leftVelocity;
    Vector3 downVelocity;
    Vector3 jumpForce;
    Vector3 finalRightVelocity;
    Vector3 finalLeftVelocity;
    bool canJump;

    float currentGravity;
    void Start()
    {
        rightVelocity = new Vector3(10, 0, 0);
        leftVelocity = new Vector3(-10, 0, 0);
        downVelocity = new Vector3(0, -5, 0);
        jumpForce = new Vector3(0, 15, 0);
        pacmanPhysicsEngine = GetComponent<Rigidbody2D>(); //gets physics engine
        currentGravity = 0f;
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentGravity = pacmanPhysicsEngine.velocity.y; //saving current "gravity"
           // Debug.Log("Right arrow key pressed");
            //pacmanPhysicsEngine.AddForce(rightVelocity);
            //pacmanPhysicsEngine.velocity = rightVelocity;

            finalRightVelocity = new Vector3(rightVelocity.x, currentGravity, 0);
            pacmanPhysicsEngine.velocity = finalRightVelocity;
            //in theory...
            //pacmanPhysicsEngine.velocity.y = currentGravity; //doesn't work due to unity arch
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentGravity = pacmanPhysicsEngine.velocity.y; //saving current "gravity"

            //Debug.Log("left arrow pressed");
            //pacmanPhysicsEngine.velocity = leftVelocity;
            finalLeftVelocity = new Vector3(leftVelocity.x, currentGravity, 0);
            pacmanPhysicsEngine.velocity = finalLeftVelocity;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //only returns true for one frame
        {
            //Debug.Log("up arrow pressed");

            if (canJump == true) //if pacman can jump
            {
                //jump and disable future jumping
                pacmanPhysicsEngine.AddForce(jumpForce, ForceMode2D.Impulse);
                canJump = false;
            }

            //pacmanPhysicsEngine.velocity = jumpForce;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("down arrow pressed");
            pacmanPhysicsEngine.velocity = downVelocity;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "groundTiles")
        {
            //if ran into the ground
            canJump = true;
        }
    }
}
