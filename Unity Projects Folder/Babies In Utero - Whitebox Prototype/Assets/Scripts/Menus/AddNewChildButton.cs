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
        clearAllButtons();
    }

    public void CreateNewChild() {
        //Check if Child's Name exists and if you want to replace it (replace child, add to child, or back to menu)
        string chlidName = addingChildName.GetComponent<InputField>().text;
        int checkIfNewChildHasPosition = SaveSystemController.GetComponent<SettingsBinary>().childList.IndexOf(chlidName);
        int countNum = 0;

        //Check for and make duplicate children with a number at the end
        while (checkIfNewChildHasPosition != -1)
        {
            countNum++;
            checkIfNewChildHasPosition = SaveSystemController.GetComponent<SettingsBinary>().childList.IndexOf(chlidName + countNum.ToString());
        }
        if (countNum > 0) {chlidName = chlidName + countNum.ToString();}

        if (checkIfNewChildHasPosition == -1) {
            //Add Button To ContentParent using name in the text of addingChildName
            //Create and store new button inside var
            GameObject newButton = Instantiate(ButtonToAdd, transform.position, Quaternion.identity, GameObject.Find("ContentParent").transform);
            int thisIndex = AddChildButton.transform.GetSiblingIndex();

            //Pull child stats from the add new child settings
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
            SaveSystemController.GetComponent<ChildStatsBinary>().childSex = childSex;
            SaveSystemController.GetComponent<ChildStatsBinary>().dueDate = dueDate;
            SaveSystemController.GetComponent<ChildStatsBinary>().birthDate = birthDate;
            
            //Zeros out anything saved from last child added
            for (int i = 0; i < 3; i++)
            {
                SaveSystemController.GetComponent<ChildStatsBinary>().setUpWeek[i] = false;

                SaveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[i] = 0;
                SaveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[i] = 0;
                SaveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[i] = 0;
                SaveSystemController.GetComponent<ChildStatsBinary>().armLength[i] = 0;
                SaveSystemController.GetComponent<ChildStatsBinary>().legLength[i] = 0;
            }
            SaveSystemController.GetComponent<ChildStatsBinary>().setUpWeek[selectedWeek] = true;

            SaveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[selectedWeek] = headDiameterMajor;
            SaveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[selectedWeek] = headDiameterMinor;
            SaveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[selectedWeek] = headRumpLength;
            SaveSystemController.GetComponent<ChildStatsBinary>().armLength[selectedWeek] = armLength;
            SaveSystemController.GetComponent<ChildStatsBinary>().legLength[selectedWeek] = legLength;

            SaveSystemController.GetComponent<ChildStatsBinary>().CmOrIn = CmOrIn;

            //Check and Save New Child's Name as a new binary save file
            SaveSystemController.GetComponent<ChildStatsBinary>().SaveSettings();
        
        }

    }
      public void clearWeek() {
        int selectedWeek = addingSelectedWeek.GetComponent<Dropdown>().value;
        SaveSystemController.GetComponent<ChildStatsBinary>().setUpWeek[selectedWeek] = false;

        SaveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[selectedWeek] = 0;
        SaveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[selectedWeek] = 0;
        SaveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[selectedWeek] = 0;
        SaveSystemController.GetComponent<ChildStatsBinary>().armLength[selectedWeek] = 0;
        SaveSystemController.GetComponent<ChildStatsBinary>().legLength[selectedWeek] = 0;
        //updateButtonsOnScreen();
    }

    public void clearAllButtons() {
        addingChildName.GetComponent<InputField>().text = "";
        addingChildSex.GetComponent<Dropdown>().value = 0;
        addingChildDue.GetComponent<InputField>().text = "";
        addingChildBirth.GetComponent<InputField>().text = "";
        addingChildHeadToRump.GetComponent<InputField>().text = "";
        addingChildHeadDMajor.GetComponent<InputField>().text = "";
        addingChildHeadDMinor.GetComponent<InputField>().text = "";
        addingChildArmL.GetComponent<InputField>().text = "";
        addingChildLegL.GetComponent<InputField>().text = "";
        addingCmOrIn.GetComponent<ToggleController>().isOn = true;
    }
}
