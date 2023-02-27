using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieDamage : MonoBehaviour
{
    // Start is called before the first frame update

    int health = 10;
    GameObject zombieAudioObject;
    AudioSource zombieAudio;
    void Start()
    {
        zombieAudioObject = GameObject.Find("ZombieAudio");
        zombieAudio = zombieAudioObject.GetComponent<AudioSource>();
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

            //play damage audio
            zombieAudio.Play();
        }

        if(health <=0)
        {
            Debug.Log("Destroying zombie");

            GameObject thePlayer = GameObject.Find("Woodcutter");
            //mark character for sparing when scene changes
            DontDestroyOnLoad(thePlayer);


            //transition level since zombie is destroyed
            SceneManager.LoadScene("SecondLevel");


            Destroy(this.gameObject);
        }
    }
}
