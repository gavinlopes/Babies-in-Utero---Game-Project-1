using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateChildButton : MonoBehaviour
{
    public String_SO selectedChildSO;
    public GameObject saveSystemController;
    public GameObject addingChildName;
    //public

    public void UpdateChildName() {
        string newChildName = addingChildName.GetComponent<InputField>().text;
        int checkIfNewChildHasPosition = saveSystemController.GetComponent<SettingsBinary>().childList.IndexOf(newChildName);

        if (checkIfNewChildHasPosition == -1) {
            //store old child info
            string oldChildName = selectedChildSO.currentString;
            int childPosition = saveSystemController.GetComponent<SettingsBinary>().childList.IndexOf(oldChildName);

            //update old child info with new info
            selectedChildSO.UpdateString(newChildName);
            saveSystemController.GetComponent<SettingsBinary>().childList[childPosition] = newChildName;
            saveSystemController.GetComponent<SettingsBinary>().SaveChildList();

            
            saveSystemController.GetComponent<ChildStatsBinary>().chlidName = oldChildName;
            saveSystemController.GetComponent<ChildStatsBinary>().LoadSettings();
            saveSystemController.GetComponent<ChildStatsBinary>().chlidName = newChildName;
            saveSystemController.GetComponent<ChildStatsBinary>().SaveSettings();
            saveSystemController.GetComponent<ChildStatsBinary>().DeleteSettings(oldChildName);
        }
    }
}
