using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorScript : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject loseMessage;
    Vector3 spawnSpot;
    void Start()
    {
        loseMessage = GameObject.Find("loseSprite");
        loseMessage.SetActive(false);
        spawnSpot = new Vector3(-7.2f, 15.4f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "ThePlayer")
        {
            Debug.Log("Player hit death floor");
            collision.gameObject.transform.position = spawnSpot;


            //loseMessage.SetActive(true);
            //Destroy(collision.gameObject);
        }

    }
}
