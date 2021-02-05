using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddNewChildButton : MonoBehaviour
{
    // For adding buttons to ContentParent in Hierarchy
    public GameObject ButtonToAdd;
    public GameObject AddChildButton;
    public GameObject SaveSystemController;

    // UI GameObjects that hold New Child Stats
    public GameObject addingChildName;
    public GameObject addingChildSize;

    public void CreateNewChild() {
        //Check if Child's Name exists and if you want to replace it (replace child, add to child, or back to menu)

        //Add Button To ContentParent using name in the text of addingChildName
        //Create and store new button inside var
        GameObject newButton = Instantiate(ButtonToAdd, transform.position, Quaternion.identity, GameObject.Find("ContentParent").transform);
        int thisIndex = AddChildButton.transform.GetSiblingIndex();
        string chlidName = addingChildName.GetComponent<InputField>().text;
        float childSize = float.Parse(addingChildSize.GetComponent<InputField>().text);
        //Set vars for newButton
        newButton.transform.SetSiblingIndex(thisIndex);
        newButton.GetComponent<ChildButtonParented>().childName = chlidName;
        newButton.SetActive(true);

        //Add text in addingChildName to SaveSystem ChildList list
        //SaveSystemController.GetComponent<SettingsBinary>().childList.Add(chlidName);
        SaveSystemController.GetComponent<SettingsBinary>().childList.Add(chlidName);

        //Activate Save function in SaveSystem
        SaveSystemController.GetComponent<SettingsBinary>().SaveChildList();


        //Create, Add, and Save weekly stats to new child save file
        //SaveSystemController.GetComponent<ChildStatsBinary>().chlidID = chlidName;
        SaveSystemController.GetComponent<ChildStatsBinary>().chlidName = chlidName;
        SaveSystemController.GetComponent<ChildStatsBinary>().childSize = childSize;

        //Check and Save New Child's Name as a new binary save file
        SaveSystemController.GetComponent<ChildStatsBinary>().SaveSettings();
        

    }
}
