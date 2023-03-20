using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

//depending on your version of urp you might need:
// using UnityEngine.Rendering.Universal;

public class LightScript10 : MonoBehaviour
{
    // Start is called before the first frame update
    Light2D characterLight;
    bool lightIncreasing = true;
    void Start()
    {
        characterLight = GameObject.Find("CharacterLight").GetComponent<Light2D>();
        StartCoroutine(lightFlash());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator lightFlash()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);

            //if light is getting brighter and is not too bright
            if(lightIncreasing == true && characterLight.intensity <= 15)
            {
                characterLight.intensity += 3; //brighten
            }
            else if(lightIncreasing == true && characterLight.intensity > 15) //if light is too bright
            {
                lightIncreasing = false; //start dimming
            }

            //if light is getting dimmer and is not too dim
            if(lightIncreasing == false && characterLight.intensity >= 0) 
            {
                characterLight.intensity -= 3; //dim light
            }
            else if(lightIncreasing == false && characterLight.intensity < 0) //if light is too dim
            {
                lightIncreasing = true; //Start brightening
            }

            
        }
    }
}
