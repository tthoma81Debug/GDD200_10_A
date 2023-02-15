using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathFloorScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject loseScreen;
    void Start()
    {
        loseScreen = GameObject.Find("loseSprite");
        loseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "ThePlayer")
        {
            //player ran into deathfloor

            //show lose screen
            loseScreen.SetActive(true);
            loseScreen.transform.position = collision.gameObject.transform.position;

            Destroy(collision.gameObject);
        }
    }

}
