using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class ChildStatsSaveSystem 
{
    // Settings Data
    public static void SaveSettings (ChildStatsBinary childStatsBinary, string childName) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath +  "/"+ childName +"Stats.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        ChildStatsData data = new ChildStatsData(childStatsBinary);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ChildStatsData LoadSettings (string childName) {
        string path = Application.persistentDataPath + "/"+ childName +"Stats.sav";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ChildStatsData data = formatter.Deserialize(stream) as ChildStatsData;
            
            stream.Close();

            return data;
        } else {
            Debug.Log(childName + "Stats.sav file not found in " + path);
            return null;
        }
    }
}
