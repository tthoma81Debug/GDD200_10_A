using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject theGameManager;
    Inventory theInventoryScript;
    GameObject inventorySlot1;
    SpriteRenderer inventorySlot1Renderer;
    void Start()
    {
        theGameManager = GameObject.Find("GameManager");
        theInventoryScript = theGameManager.GetComponent<Inventory>();
        inventorySlot1 = GameObject.Find("InventorySlot1");
        inventorySlot1Renderer = inventorySlot1.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Woodcutter")
        {
            Debug.Log("picked up by player");

            //add self to inventory

            if(theInventoryScript.nextSpot <= theInventoryScript.lastValidSpot)
            {
                theInventoryScript.theInventory[theInventoryScript.nextSpot] = this.gameObject;
                theInventoryScript.nextSpot++;
                //Destroy(this.gameObject);

                //disable sprite
                //this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

                //change sprite of inventory slot 1 to match
                inventorySlot1Renderer.sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                Debug.Log("Inventory Full. Cannot pick up item");
            }
            
            
            
            
            
        }
    }
}
