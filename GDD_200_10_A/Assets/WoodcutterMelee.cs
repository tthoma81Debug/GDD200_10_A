using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodcutterMelee : MonoBehaviour
{
    // Start is called before the first frame update
    Animator woodcutterAnimator;
    GameObject axeSwingAudioObject;
    AudioSource axeSwingAudio;

    GameObject theGameManager;
    Inventory theInventoryScript;

    public GameObject fireballPrefab;
    private GameObject spawnedFireball;
    private GameObject spawnPoint;

    private IEnumerator theCoroutine;

    private bool onTimer = false;


    void Start()
    {
        woodcutterAnimator = GetComponent<Animator>();
        axeSwingAudioObject = GameObject.Find("AxeSwingAudio");
        axeSwingAudio = axeSwingAudioObject.GetComponent<AudioSource>();

        theGameManager = GameObject.Find("GameManager");
        theInventoryScript = theGameManager.GetComponent<Inventory>();
        spawnPoint = GameObject.Find("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            //melee attack
            woodcutterAnimator.SetBool("MeleeButtonPressed", true);

            //play sound
            axeSwingAudio.Play();
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            //magic attack
            GameObject fireball = theInventoryScript.find("pocket_sun");

            if(fireball != null)
            {
                Debug.Log("Attacking with " + fireball.name);

                //spawn fireball

                if(onTimer == false)
                {
                    //spawnedFireball = Instantiate(fireballPrefab, spawnPoint.transform.position, Quaternion.identity);
                    StartCoroutine(fireballDelay());
                }
               
                


            }
            else
            {
                Debug.Log("Pocket sun not in inventory. Cannot magic attack");
            }
        }
    }

    private IEnumerator fireballDelay()
    {
        while (true)
        {


            onTimer = true;
            spawnedFireball = Instantiate(fireballPrefab, spawnPoint.transform.position, Quaternion.identity);

            //does this code on the frame it is started
            //yield return null; //waits here until the next frame
            //does this code after the frame has passed

            //does this code on the frame it is called
            yield return new WaitForSeconds(3); //waits three seconds
                                                //then does the code down here

            Rigidbody2D fireballPhysics = spawnedFireball.GetComponent<Rigidbody2D>();
            Vector3 fireballForce = new Vector3(30, 7, 0);

            fireballPhysics.AddForce(fireballForce, ForceMode2D.Impulse);

            yield return new WaitForSeconds(3); //waits three more seconds
                                                //then does the code down here

            fireballForce = new Vector3(-30, 7, 0);

            fireballPhysics.AddForce(fireballForce, ForceMode2D.Impulse);

            //onTimer = false;
            //never "truly" returns
            //finishes here
        }
    }
}
