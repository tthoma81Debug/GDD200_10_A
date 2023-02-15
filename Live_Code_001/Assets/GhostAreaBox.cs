using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAreaBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ThePlayer")
        {
            Debug.Log("Player entering in ghost zone. Look out!");
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ThePlayer")
        {
            Debug.Log("Player Leaving Ghost Zone");
        }
    }
}
