using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallscript : MonoBehaviour
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
        //runs when trigger entered
        Debug.Log("Trigger tripped by " + collision.gameObject.name);

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Pacman has left the building");
    }
}
