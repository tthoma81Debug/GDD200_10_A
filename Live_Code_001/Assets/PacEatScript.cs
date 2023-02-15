using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacEatScript : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isChomping;
    void Start()
    {
        isChomping = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BadGhost"))
        {
            Debug.Log("This is pacman. ran into a ghost");
        }
    }
}
