using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChildButtonParented : MonoBehaviour
{
    public String_SO selectedChildSO;
    public string childName;

    void Start()
    {
        UpdateChildButton();
    }

    void OnEnable() 
    {
        UpdateChildButton();
    }

    void UpdateChildButton() 
    {
        // Check if the .txt file exists for child?

        
        //Variables
        GameObject buttonText = this.transform.GetChild(0).gameObject;
        int siblingIndex = this.transform.GetSiblingIndex();

        //Rename object the name of child
        this.name = "Button For " + childName;

        //Update the name of the child on the button
        buttonText.GetComponent<TextMeshProUGUI>().text = childName;
    }

    public void UpdateSelectedChild()
    {
        selectedChildSO.currentString = childName;
    }
}
