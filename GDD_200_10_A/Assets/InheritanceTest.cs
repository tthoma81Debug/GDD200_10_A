using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceTest : MonoBehaviour
{
    // Start is called before the first frame update

    AstronomicalBody moonScript;
    void Start()
    {
        //referring to moonscript by base type
        moonScript = GameObject.Find("moon").GetComponent<AstronomicalBody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            //test when t is pressed
            moonScript.doesItWork(); //should call the version on derived object
        }
    }
}
