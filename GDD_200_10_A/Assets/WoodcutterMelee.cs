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
    void Start()
    {
        woodcutterAnimator = GetComponent<Animator>();
        axeSwingAudioObject = GameObject.Find("AxeSwingAudio");
        axeSwingAudio = axeSwingAudioObject.GetComponent<AudioSource>();

        theGameManager = GameObject.Find("GameManager");
        theInventoryScript = theGameManager.GetComponent<Inventory>();
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
            }
            else
            {
                Debug.Log("Pocket sun not in inventory. Cannot magic attack");
            }
        }
    }
}
