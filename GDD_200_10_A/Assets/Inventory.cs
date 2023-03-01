using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] theInventory;
    public int nextSpot; //next position in array
    public int lastValidSpot; //last usable position in array;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        nextSpot = 0;
        lastValidSpot = 9;
        theInventory = new GameObject[10]; //actually has 10 spots at position 0 through 9
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject find(string thingToFind)
    {
        GameObject thingFound = null;

        for(int i = 0; i < theInventory.Length; i++)
        {

            if(theInventory[i] != null)
            {
                if (theInventory[i].name == thingToFind)
                {
                    //found the gameObject
                    thingFound = theInventory[i];
                }
            }

        }


        return thingFound;
    }
}
