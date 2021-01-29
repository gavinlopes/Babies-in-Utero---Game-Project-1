using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class BrackysSaveSystem 
{
    public static void SavePlayer (Player player) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/brakeysTest.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer() {
        string path = Application.persistentDataPath + "/brakeysTest.sav";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            
            stream.Close();

            return data;
        } else {
            Debug.Log("Save file not found in " + path);
            return null;
        }
    }
}