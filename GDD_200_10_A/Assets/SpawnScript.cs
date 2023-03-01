using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject thePlayer;
    void Start()
    {
        thePlayer = GameObject.Find("Woodcutter");
        thePlayer.transform.position = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
