using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    // Start is called before the first frame update

    ParticleSystem theSystem;
    void Start()
    {
        theSystem = GetComponent<ParticleSystem>();
        StartCoroutine(gravityOn());
        

        //won't compile. Use the above instead
        //ParticleSystem.emission.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator gravityOn()
    {
        yield return new WaitForSeconds(4);

        //should compile. This is how we can access modules
        ParticleSystem.EmissionModule theModule = theSystem.emission;
        theSystem.gravityModifier = 1f;
        theModule.enabled = false;


    }

}
