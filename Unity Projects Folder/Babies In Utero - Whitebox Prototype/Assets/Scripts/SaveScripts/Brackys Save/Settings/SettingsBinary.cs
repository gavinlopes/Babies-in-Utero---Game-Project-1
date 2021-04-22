using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

//C:\Users\Nathan E\AppData\LocalLow\DefaultCompany\Babies In Utero - Whitebox Prototype

public class SettingsBinary : MonoBehaviour
{
    //Saving and Loading Settings
    public GameObject musicVolumeSlider;
    public GameObject effectsVolumeSlider;
    public GameObject voiceVolumeSlider;
    
    public GameObject cameraViewToggle;
    public GameObject sightReticleToggle;

    public bool cameraView;
    public bool sightReticle;
    
    //Saving and Loading Children
    public GameObject ButtonToDuplicate;
    public GameObject LastButtonInList;
    public List<string> childList = new List<string>();

    private void Awake() {
        string path = Application.persistentDataPath + "/settings.saV";
        if (!File.Exists(path)) {
            SettingsSaveSystem.SaveSettings(this);
        } else {
            LoadSettings();
        }
        
        path = Application.persistentDataPath + "/childList.saV";
        if (!File.Exists(path)) {
            SettingsSaveSystem.SaveChildList(this);
            checkForEmptyChildList();
        } else {
            LoadChildList();
            checkForEmptyChildList();
        }
    }

    // Settings Data
    public void SaveSettings () {
        SettingsSaveSystem.SaveSettings(this);
    }

    public void LoadSettings () {
        SettingsData data = SettingsSaveSystem.LoadSettings();

        cameraView = data.cameraView;
        sightReticle = data.sightReticle;

        voiceVolumeSlider.GetComponent<Slider>().value = data.voiceVolume;
        effectsVolumeSlider.GetComponent<Slider>().value = data.effectsVolume;
        musicVolumeSlider.GetComponent<Slider>().value = data.musicVolume;

        cameraViewToggle.GetComponent<ToggleController>().isOn = data.cameraView;
        sightReticleToggle.GetComponent<ToggleController>().isOn = data.sightReticle;
    }

    // Child Data
    public void SaveChildList () {
        SettingsSaveSystem.SaveChildList(this);
    }

    public void LoadChildList () {
        ChildListData data = SettingsSaveSystem.LoadChildList();

        childList.Clear();
        
        //Add any children back to the list
        for (int i = 0; i < data.childList.Length; i++) {
            childList.Add(data.childList[i]);

            //Create Child Buttons
            AddChildButton(data.childList[i]);
        }
    }

    
    // Other Functions
    private void AddChildButton(string childName) {
        //Create and store new button inside var
        GameObject newButton = Instantiate(ButtonToDuplicate, transform.position, Quaternion.identity, GameObject.Find("ContentParent").transform);
        int thisIndex = LastButtonInList.transform.GetSiblingIndex();
        //string childNameString = ChildOrderList.mylist[0];

        newButton.transform.SetSiblingIndex(thisIndex);
        newButton.GetComponent<ChildButtonParented>().childName = childName;
        newButton.SetActive(true);
    }

    
    private void checkForEmptyChildList() {
        ChildListData data = SettingsSaveSystem.LoadChildList();
        //If empty add default child
        if (data.childList.Length == 0) {
            this.GetComponent<ChildStatsBinary>().setStatDefults();
            this.GetComponent<ChildStatsBinary>().SaveSettings();
            childList.Add("Default Child");
            SaveChildList();
            LoadChildList();
        }
    }
}