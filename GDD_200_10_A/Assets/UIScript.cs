using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject battleTextObject;
    Text textComponent;
    void Start()
    {
        battleTextObject = GameObject.Find("BattleText");
        textComponent = battleTextObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doThisWhenClicked(int whichButton)
    {
        if(whichButton == 0)
        {
           // Debug.Log("The button at the top right has been clicked");
           //change text at top center
           textComponent.text = "You Win!!!!!";

        }
        else
        {
            //Debug.Log("The button at the top left has been clicked");
        }
       
    }
}
