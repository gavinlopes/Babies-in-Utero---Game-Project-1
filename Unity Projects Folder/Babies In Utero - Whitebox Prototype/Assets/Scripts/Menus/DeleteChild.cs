using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteChild : MonoBehaviour
{
    public GameObject SaveSystemController;
    public GameObject ChildNameInput;
    //public GameObject Parent;

    public void DeleteChildSave(){
        string childName = ChildNameInput.GetComponent<InputField>().text;
        GameObject buttonToDelete = GameObject.Find("Button For " + childName);

        //Remove name from list and remove button
        SaveSystemController.GetComponent<SettingsBinary>().childList.Remove(childName);
        Destroy(buttonToDelete);
        SaveSystemController.GetComponent<SettingsBinary>().SaveChildList();

        //Find and delete child save
        //
    }
}