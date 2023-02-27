using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodcutterMelee : MonoBehaviour
{
    // Start is called before the first frame update
    Animator woodcutterAnimator;
    GameObject axeSwingAudioObject;
    AudioSource axeSwingAudio;
    void Start()
    {
        woodcutterAnimator = GetComponent<Animator>();
        axeSwingAudioObject = GameObject.Find("AxeSwingAudio");
        axeSwingAudio = axeSwingAudioObject.GetComponent<AudioSource>();
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
    }
}
