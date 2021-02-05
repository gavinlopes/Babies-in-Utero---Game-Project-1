using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

//C:\Users\Nathan E\AppData\LocalLow\DefaultCompany\Babies In Utero - Whitebox Prototype

public class ChildStatsBinary : MonoBehaviour
{
    //public GameObject SaveSystemController;
    public string chlidName;
    public float childSize;

    // Child Stats Data
    public void SaveSettings () {
        ChildStatsSaveSystem.SaveSettings(this, chlidName);
    }

    public void LoadSettings () {
        //SettingsData data = ChildStatsSaveSystem.LoadSettings();
        //chlidID = ChildStatsSaveSystem.LoadSettings(chlidID).chlidID;
        chlidName = ChildStatsSaveSystem.LoadSettings(chlidName).chlidName;
        childSize = ChildStatsSaveSystem.LoadSettings(chlidName).childSize;
    }
    
    //WIP
    public void UpdateSettings(string newChildName) {
        string oldChildName = chlidName;
        chlidName = newChildName;

        //Save updated settins
        //ChildStatsSaveSystem.SaveSettings(this, chlidName);

        //Delete old child settings
        //DeleteSettings(oldChildName);

        /// Find and Update Button
        GameObject buttonToUpdate = GameObject.Find("Button For " + oldChildName);
        //string buttonText = buttonToUpdate.GetComponent<InputField>().text;

        //this.GetComponent<SettingsBinary>().childList.Remove(oldChildName);
        //Destroy(buttonToUpdate);

        Debug.Log(buttonToUpdate);

        // Update Button Name
        buttonToUpdate.name = "Button For " + chlidName;
        buttonToUpdate = GameObject.Find("Button For " + chlidName);

        // Update text inside of button
        //buttonToUpdate.gameObject.transform.GetChild(0).GetComponents<TMP_UI>().text = chlidName;
        
        Debug.Log(buttonToUpdate);

        /// Find and Update Name in list
        //this.GetComponent<SettingsBinary>().childList.Add(newChildName);
    }

    public void DeleteSettings(string chlidID) {
        string path = Application.persistentDataPath + "/"+ chlidID +"Stats.sav";
        if (File.Exists(path)) {
            File.Delete(path); 
            Debug.Log("Deleted This!  "+path);
        } else {
            Debug.Log(chlidID + "Stats.sav file not found in " + path);
        }
    }
}
