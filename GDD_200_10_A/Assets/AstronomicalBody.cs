using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronomicalBody : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void doesItWork()
    {
        Debug.Log("doesItWork function called from base object, not derived object");
    }
}
