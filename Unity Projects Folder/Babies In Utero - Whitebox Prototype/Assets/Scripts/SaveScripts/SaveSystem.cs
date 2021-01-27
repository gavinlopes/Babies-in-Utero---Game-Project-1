using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class SaveSystem
{
    public static readonly string SAVE_FOLDER = Application.dataPath + "/Resources/";

    public static void Init() {
        // Test if Resources folder exists
        if (!Directory.Exists(SAVE_FOLDER)) {
            //Create Resources Folder
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }

    public static void Save(string saveString, string childName) {
        File.WriteAllText(SAVE_FOLDER + childName + ".txt", saveString);
    }

    public static string Load(string childName) {
        if (File.Exists(SAVE_FOLDER + childName + ".txt")) {
            string saveString = File.ReadAllText(SAVE_FOLDER + childName + ".txt");
            return saveString;
        } else {
            return null;
        }
    }
}
