using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class ChildListData
{
    public string[] childList;

    public ChildListData (SettingsBinary settingsBinary) {
        childList = new string[settingsBinary.childList.Count];

        for (int i = 0; i < childList.Length; i++) {
            childList[i] = settingsBinary.childList[i];
        }
    }
}
