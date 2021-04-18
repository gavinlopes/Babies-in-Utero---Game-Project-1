using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateChildButton : MonoBehaviour
{
        //NOTE: somehow, it only updates when a new name is picked

    public String_SO selectedChildSO;
    public GameObject saveSystemController;

    // UI GameObjects that hold Child Stats
    public GameObject addingChildName;
    public GameObject addingChildSex;
    public GameObject addingChildDue;
    public GameObject addingChildBirth;
    public GameObject addingChildHeadToRump;
    public GameObject addingChildHeadDMajor;
    public GameObject addingChildHeadDMinor;
    public GameObject addingChildArmL;
    public GameObject addingChildLegL;
    public GameObject addingCmOrIn;
    public GameObject addingSelectedWeek;

    private void OnEnable() {
        saveSystemController.GetComponent<ChildStatsBinary>().chlidName = selectedChildSO.currentString;
        saveSystemController.GetComponent<ChildStatsBinary>().LoadSettings();
        updateButtonsOnScreen();
    }

    public void UpdateChildStats(string cn) {
        //UpdateChildName();

        //Pull child stats from the update child settings
        int childSex = addingChildSex.GetComponent<Dropdown>().value;
        string dueDate = addingChildDue.GetComponent<InputField>().text;
        string birthDate = addingChildBirth.GetComponent<InputField>().text;
        float headRumpLength = float.Parse(addingChildHeadToRump.GetComponent<InputField>().text);
        float headDiameterMajor = float.Parse(addingChildHeadDMajor.GetComponent<InputField>().text);
        float headDiameterMinor = float.Parse(addingChildHeadDMinor.GetComponent<InputField>().text);
        float armLength = float.Parse(addingChildArmL.GetComponent<InputField>().text);
        float legLength = float.Parse(addingChildLegL.GetComponent<InputField>().text);
        bool CmOrIn = addingCmOrIn.GetComponent<ToggleController>().isOn;

        int selectedWeek = addingSelectedWeek.GetComponent<Dropdown>().value;

        //Create, Add, and Save weekly stats to child save file
        saveSystemController.GetComponent<ChildStatsBinary>().chlidName = cn;
        saveSystemController.GetComponent<ChildStatsBinary>().childSex = childSex;
        saveSystemController.GetComponent<ChildStatsBinary>().dueDate = dueDate;
        saveSystemController.GetComponent<ChildStatsBinary>().birthDate = birthDate;

        saveSystemController.GetComponent<ChildStatsBinary>().setUpWeek[selectedWeek] = true;

        saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[selectedWeek] = headDiameterMajor;
        saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[selectedWeek] = headDiameterMinor;
        saveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[selectedWeek] = headRumpLength;
        saveSystemController.GetComponent<ChildStatsBinary>().armLength[selectedWeek] = armLength;
        saveSystemController.GetComponent<ChildStatsBinary>().legLength[selectedWeek] = legLength;

        saveSystemController.GetComponent<ChildStatsBinary>().CmOrIn = CmOrIn;

        //Check and Save New Child's Name as a new binary save file
        saveSystemController.GetComponent<ChildStatsBinary>().SaveSettings();
    }

    public void UpdateChildName() {
        //Check if Child's Name exists and if you want to replace it (replace child, add to child, or back to menu)
        string newChildName = addingChildName.GetComponent<InputField>().text;
        int checkIfNewChildHasPosition = saveSystemController.GetComponent<SettingsBinary>().childList.IndexOf(newChildName);
        //int countNum = 0;

        //Check for and make duplicate children with a number at the end
        /*while (checkIfNewChildHasPosition != -1)
        {
            countNum++;
            checkIfNewChildHasPosition = saveSystemController.GetComponent<SettingsBinary>().childList.IndexOf(newChildName + countNum.ToString());
        }
        if (countNum > 0) {newChildName = newChildName + countNum.ToString();}
        */
        // check for...
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
        
        UpdateChildStats(newChildName);
    }

    public void clearWeek() {
        int selectedWeek = addingSelectedWeek.GetComponent<Dropdown>().value;
        saveSystemController.GetComponent<ChildStatsBinary>().setUpWeek[selectedWeek] = false;

        saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[selectedWeek] = 0;
        saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[selectedWeek] = 0;
        saveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[selectedWeek] = 0;
        saveSystemController.GetComponent<ChildStatsBinary>().armLength[selectedWeek] = 0;
        saveSystemController.GetComponent<ChildStatsBinary>().legLength[selectedWeek] = 0;
        updateButtonsOnScreen();
    }

    public void updateButtonsOnScreen() {
        int selectedWeek = addingSelectedWeek.GetComponent<Dropdown>().value;

        saveSystemController.GetComponent<ChildStatsBinary>().SaveSettings();
        addingChildName.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().chlidName;
        addingChildSex.GetComponent<Dropdown>().value = saveSystemController.GetComponent<ChildStatsBinary>().childSex;
        addingChildDue.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().dueDate;
        addingChildBirth.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().birthDate;

        if (saveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[selectedWeek] != 0) {
            addingChildHeadToRump.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[selectedWeek].ToString();
        } else {addingChildHeadToRump.GetComponent<InputField>().text = ""; }
        
        if (saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[selectedWeek] != 0) {
            addingChildHeadDMajor.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[selectedWeek].ToString();
        } else {addingChildHeadDMajor.GetComponent<InputField>().text = ""; }
        
        if (saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[selectedWeek] != 0) {
            addingChildHeadDMinor.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[selectedWeek].ToString();
        } else {addingChildHeadDMinor.GetComponent<InputField>().text = ""; }
        
        if (saveSystemController.GetComponent<ChildStatsBinary>().armLength[selectedWeek] != 0) {
            addingChildArmL.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().armLength[selectedWeek].ToString();
        } else {addingChildArmL.GetComponent<InputField>().text = ""; }
        
        if (saveSystemController.GetComponent<ChildStatsBinary>().legLength[selectedWeek] != 0) {
            addingChildLegL.GetComponent<InputField>().text = saveSystemController.GetComponent<ChildStatsBinary>().legLength[selectedWeek].ToString();
        } else {addingChildLegL.GetComponent<InputField>().text = ""; }

        addingCmOrIn.GetComponent<ToggleController>().isOn = saveSystemController.GetComponent<ChildStatsBinary>().CmOrIn;
    }
}
