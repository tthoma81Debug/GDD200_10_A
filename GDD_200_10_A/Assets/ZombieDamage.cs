using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    // Start is called before the first frame update

    int health = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);
        if(collision.gameObject.name == "AttackBox")
        {
            Debug.Log("Damaging Zombie");
            health -= 3;
        }

        if(health <=0)
        {
            Debug.Log("Destroying zombie");
            Destroy(this.gameObject);
        }
    }
}
