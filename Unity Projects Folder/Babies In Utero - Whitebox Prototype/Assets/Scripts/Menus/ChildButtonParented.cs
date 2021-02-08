using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChildButtonParented : MonoBehaviour
{
    public String_SO selectedChildSO;
    public GameObject saveSystemController;
    public string childName;

    void Start()
    {
        int number = this.transform.GetSiblingIndex();
        //childName = saveSystemController.GetComponent<SettingsBinary>().childList[number];
        //UpdateChildButton(childName);

        if (number >= saveSystemController.GetComponent<SettingsBinary>().childList.Count) {
            Destroy(this);
        } else {
            childName = saveSystemController.GetComponent<SettingsBinary>().childList[number];
            UpdateChildButton(childName);
        }
    }

    void OnEnable() 
    {
        int number = this.transform.GetSiblingIndex();
        //childName = saveSystemController.GetComponent<SettingsBinary>().childList[number];
        //UpdateChildButton(childName);

        if (number > saveSystemController.GetComponent<SettingsBinary>().childList.Count) {
            Destroy(this);
        } else {
            childName = saveSystemController.GetComponent<SettingsBinary>().childList[number];
            UpdateChildButton(childName);
        }
    }

    void UpdateChildButton(string n) 
    {
        // Check if the .txt file exists for child?

        
        //Variables
        GameObject buttonText = this.transform.GetChild(0).gameObject;
        int siblingIndex = this.transform.GetSiblingIndex();

        //Rename object the name of child
        this.name = "Button For " + n;

        //Update the name of the child on the button
        buttonText.GetComponent<TextMeshProUGUI>().text = n;
    }

    public void UpdateSelectedChild()
    {
        selectedChildSO.currentString = childName;
    }
}
