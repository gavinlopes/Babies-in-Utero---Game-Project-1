using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsBinary : MonoBehaviour
{
    //Saving and Loading Settings
    public GameObject voiceVolumeSlider;
    public GameObject musicVolumeSlider;
    public GameObject cameraViewToggle;
    public GameObject sightReticleToggle;
    
    //Saving and Loading Children
    public GameObject ButtonToDuplicate;
    public GameObject LastButtonInList;
    public List<string> childList = new List<string>();

    private void Awake() {
        LoadSettings();
        LoadChildList();
    }

    // Settings Data
    public void SaveSettings () {
        SettingsSaveSystem.SaveSettings(this);
    }

    public void LoadSettings () {
        SettingsData data = SettingsSaveSystem.LoadSettings();

        voiceVolumeSlider.GetComponent<Slider>().value = data.voiceVolume;
        musicVolumeSlider.GetComponent<Slider>().value = data.musicVolume;

        cameraViewToggle.GetComponent<Dropdown>().value = data.cameraView;//GetComponent<ToggleController>().isOn = data.cameraView;
        sightReticleToggle.GetComponent<ToggleController>().isOn = data.sightReticle;
    }

    // Child Data
    public void SaveChildList () {
        SettingsSaveSystem.SaveChildList(this);
        Debug.Log("save child list");
    }

    public void LoadChildList () {
        ChildListData data = SettingsSaveSystem.LoadChildList();

        childList.Clear();

        for (int i = 0; i < data.childList.Length; i++) {
            childList.Add(data.childList[i]);

            //Create Child Buttons
            AddChildButton(data.childList[i]);
        }
        Debug.Log("load child list");
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
}