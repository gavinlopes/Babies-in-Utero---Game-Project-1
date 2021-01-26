using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddNewChildButton : MonoBehaviour
{
    public GameObject ButtonToAdd;
    public GameObject AddChildButton;
    //public TextMeshProUGUI buttonName;
    //int numCount = 0;

    public void AddToParent()
    {
        //numCount++;

        //Create and store new button inside var
        GameObject newButton = Instantiate(ButtonToAdd, transform.position, Quaternion.identity, GameObject.Find("ContentParent").transform);
        int thisIndex = AddChildButton.transform.GetSiblingIndex();
        newButton.transform.SetSiblingIndex(thisIndex);
        newButton.SetActive(true);

        //Store text of the new button inside of var
        /*
        GameObject newButtonText = newButton.transform.GetChild(0).gameObject;

        //Activate and move sibling index for button
        newButton.name = "BabyNo" + numCount.ToString();
        
        

        //Test Nameing the button
        newButtonText.GetComponent<TextMeshProUGUI>().text = newButton.name;
        */




        /*
        //This helps figure out the names of the components attached to an object
        Component[] components = newButtonText.GetComponents(typeof(Component));
        foreach(Component component in components) {
            Debug.Log("This is the type of component " + component.ToString());
        }
        */
    }

    public void AddStats()
    {
        //Add new child to list at possition 1
        //Take stats from button sliders and add them to list/array
    }
}
