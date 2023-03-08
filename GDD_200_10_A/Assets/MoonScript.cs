using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : AstronomicalBody
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void doesItWork()
    {
        Debug.Log("doesItWork function called from derived object, not base object");
    }
}
