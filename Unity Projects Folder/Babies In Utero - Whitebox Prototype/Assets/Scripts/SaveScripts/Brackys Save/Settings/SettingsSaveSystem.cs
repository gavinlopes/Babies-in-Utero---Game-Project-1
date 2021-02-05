using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SettingsSaveSystem 
{
    // Settings Data
    public static void SaveSettings (SettingsBinary settingsBinary) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/settings.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        SettingsData data = new SettingsData(settingsBinary);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SettingsData LoadSettings() {
        string path = Application.persistentDataPath + "/settings.sav";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SettingsData data = formatter.Deserialize(stream) as SettingsData;
            
            stream.Close();

            return data;
        } else {
            Debug.Log("Settings file not found in " + path);
            return null;
        }
    }
    
    // Child List Data
    public static void SaveChildList (SettingsBinary settingsBinary) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/childList.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        ChildListData data = new ChildListData(settingsBinary);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ChildListData LoadChildList() {
        string path = Application.persistentDataPath + "/childList.sav";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ChildListData data = formatter.Deserialize(stream) as ChildListData;
            
            stream.Close();

            return data;
        } else {
            Debug.Log("ChildList file not found in " + path);
            return null;
        }
    }
}
