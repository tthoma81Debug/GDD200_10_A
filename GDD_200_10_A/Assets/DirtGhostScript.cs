using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtGhostScript : MonoBehaviour
{
    // Start is called before the first frame update

   // PacmanCollision pacmanCollisionScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "ThePlayer")
        {
            //we ran into a player. lets get its script
            pacmanCollisionScript = collision.gameObject.GetComponent<PacmanCollision>();
            if(pacmanCollisionScript.chompMode == false)
            {
                Debug.Log("hahahahaha! This is dirt ghost. We just ran into pacman and he has not eaten any fruit. Feast time!");
                Destroy(collision.gameObject);
            }
            else
            {
                //pacman in chomp mode
                Debug.Log("Oh no! This is dirt ghost. We just ran into pacman and he is hungry!");
                Destroy(this.gameObject);
            }
            //Debug.Log("Hey this ghost. We just ran into the player");
        }
    }
    */
}
