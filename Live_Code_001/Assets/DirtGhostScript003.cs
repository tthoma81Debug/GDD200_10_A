using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtGhostScript003 : MonoBehaviour
{
    // Start is called before the first frame update
    PacEatScript pacmanScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "ThePlayer")
        {
            pacmanScript = collision.gameObject.GetComponent<PacEatScript>();
            if(pacmanScript.isChomping == false)
            {
                //destroy pacman
                Destroy(collision.gameObject);
                Debug.Log("hahaha!. This is ghost. destroying pacman now");
            }
            else
            {
                //destroy ghost
                Debug.Log("Oh no! Pacman is in chomp mode. Getting eaten now");
                Destroy(this.gameObject);
            }
            //if ThePlayer's isChomping variable is false, destroy player and laugh
            //else freak out and destroy self


            //Debug.Log("This is ghost. ran into pac man");


        }
    }
}
