using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class SettingsData
{
    public float voiceVolume;
    public float musicVolume;

    public int cameraView;
    public bool sightReticle;

    public SettingsData (SettingsBinary settingsBinary) {
        voiceVolume = settingsBinary.voiceVolumeSlider.GetComponent<Slider>().value;
        musicVolume = settingsBinary.musicVolumeSlider.GetComponent<Slider>().value;

        cameraView = settingsBinary.cameraViewToggle.GetComponent<Dropdown>().value;//GetComponent<ToggleController>().isOn;
        sightReticle = settingsBinary.sightReticleToggle.GetComponent<ToggleController>().isOn;
    }
}
