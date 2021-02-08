using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    //[SerializeField] private GameObject unitGameObject;
    //private IUnit unit;
    public string GetChildName;

    private void Awake()
    {
        //unit = unitGameObject.GetComponent<IUnit>();
        //Initualize Save System into code
        SaveSystem.Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            Save();
        }
        
        if (Input.GetKeyDown(KeyCode.L)) {
            Load();
        }
    }

    private void SaveJustName() {
        string childName = GetChildName;//unit.GetChildName();


    }

    //Save
    private void Save() {
        //Get things to Save
        string childName = GetChildName;//unit.GetChildName();
        float childSizePH = 1.5f;//unit.GetChildSizePH();
        
        SaveObject saveObject = new SaveObject {
            childName = childName,
            childSizePH = childSizePH
        };
        string json = JsonUtility.ToJson(saveObject);
        SaveSystem.Save(json, "DefaultChild");

        Debug.Log("Saved! Name: " + childName + ", Size: " + childSizePH);
    }

    //Load
    private void Load() {
        TextAsset file = Resources.Load("DefaultChild") as TextAsset;
        string saveString = file.ToString();
        //string saveString = SaveSystem.Load("DefaultChild");
        if (saveString != null) {
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            
            //Set the Loded things
            //unit.SetChildName(saveObject.childName);
            //unit.SetChildSizePH(saveObject.childSizePH);

            //string saveString = File.ReadAllText(SAVE_FOLDER + childName + ".txt");
            //string content1 = saveString.ToString ();

            TextAsset files = Resources.Load("DefaultChild") as TextAsset;
            string content = files.ToString ();

            Debug.Log("Phone aproved: " + content);
            Debug.Log("PC aproved: " + saveString);

            Debug.Log("Loded! Name: " + saveObject.childName);
        } else {
            Debug.Log("No Save...");
        }
    }

    private class SaveObject {
        public string childName;
        public float childSizePH;
    }
}
