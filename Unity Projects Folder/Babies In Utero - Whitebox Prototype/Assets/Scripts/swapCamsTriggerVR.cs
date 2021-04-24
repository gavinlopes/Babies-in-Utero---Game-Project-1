using UnityEngine;
using System;

public class swapCamsTriggerVR : MonoBehaviour
{
    public DropDown_SO dropDownSO;
    public GameObject saveSystem;

    private void Start() {
        SettingsData data = SettingsSaveSystem.LoadSettings();

        if (data.cameraView) {
            dropDownSO.DropdownIndex = 0;
        } else {
            dropDownSO.DropdownIndex = 1;
        }
    }

    public void swapCams()
    {
        
        if (dropDownSO.DropdownIndex == 1)
        {
            dropDownSO.DropdownIndex = 0;
        }
        else
        {
            dropDownSO.DropdownIndex = 1;
        }
    }
}
