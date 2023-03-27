using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueScriptTwo : MonoBehaviour
{
    // Start is called before the first frame update

    Text firstOptionText;
    Text secondOptionText;
    GameObject dialoguePanel;

    int state;

    /* 0 is no choice made
     * 1 is first option
     * 2 is second option
     * 3 is first option then first option
     * 4 is first option then first option then first option
     * 5 is first option then first option, then first option, then first option
     * 
     * 6 is second option then first option
     * 7 is second option then first option then first option
     * 8 is second option then first option then first option then first option
     * 
     * 
     * 
     * 
     * 
     */



    void Start()
    {
        firstOptionText = GameObject.Find("firstOptionText").GetComponent<Text>();
        secondOptionText = GameObject.Find("secondOptionText").GetComponent<Text>();
        dialoguePanel = GameObject.Find("DialoguePanel");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void firstChoiceClicked()
    {
        Debug.Log("First Choice");


        //if(either first or second option chosen, and clicked again, close dialogue)
        if(state == 0)
        {
            firstOptionText.text = "You have chosen the first option.";
            secondOptionText.text = "";
            state = 1;
        }
        else if(state == 1)
        {
            firstOptionText.text = "Why does everyone always pick the first option?";
            secondOptionText.text = "";
            state = 3;
        }
        else if (state == 3)
        {
            firstOptionText.text = "Have you considered the second choice?. It's an option too";
            secondOptionText.text = "";
            state = 4;
        }
        else if (state == 4)
        {
            firstOptionText.text = "Oh look. a zombie. Enjoy...You who have no creativity";
            secondOptionText.text = "";
            state = 5;
        }
        //second branch here
        else if (state == 2)
        {
            firstOptionText.text = "Thats awesome! I was hoping you would pick that one!";
            secondOptionText.text = "";
            state = 6;
        }
        else if (state == 6)
        {
            firstOptionText.text = "You are super creative!";
            secondOptionText.text = "";
            state = 7;
        }
        else if (state == 7)
        {
            firstOptionText.text = "Oh no. A zombie. I heard creativity drops when one becomes undead";
            secondOptionText.text = "";
            state = 8;
        }


        else if(state == 5 || state == 8)
        {
            dialoguePanel.SetActive(false);
        }

    }

    public void secondChoiceClicked()
    {
        if(state == 0)
        {
            firstOptionText.text = "You have chosen the second option";
            secondOptionText.text = "";
            state = 2;
        }

        Debug.Log("Second Choice");
        
    }
}
