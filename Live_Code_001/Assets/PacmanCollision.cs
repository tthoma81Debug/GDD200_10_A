using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public bool chompMode;
    void Start()
    {
        chompMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hey this Pacman. We just ran into a dirt ghost");

        }
    }
}
