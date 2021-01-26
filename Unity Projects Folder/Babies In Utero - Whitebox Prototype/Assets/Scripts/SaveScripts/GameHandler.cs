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
        SaveSystem.Save(json);

        Debug.Log("Saved! Name: " + childName + ", Size: " + childSizePH);
    }

    //Load
    private void Load() {
        string saveString = SaveSystem.Load();
        if (saveString != null) {
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            
            //Set the Loded things
            //unit.SetChildName(saveObject.childName);
            //unit.SetChildSizePH(saveObject.childSizePH);

            Debug.Log("Loded! Name: " + saveString);
        } else {
            Debug.Log("No Save...");
        }
    }

    private class SaveObject {
        public string childName;
        public float childSizePH;
    }
}
