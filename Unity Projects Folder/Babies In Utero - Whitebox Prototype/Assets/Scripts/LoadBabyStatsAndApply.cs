using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBabyStatsAndApply : MonoBehaviour
{
    public String_SO selectedChildSO;
    private Vector3 childScale;

    // Start is called before the first frame update
    void Start()
    {
        //string childName = selectedChildSO.currentString;

        Load();
    }

    //Load
    private void Load() {
        string childName = selectedChildSO.currentString;
        string saveString = SaveSystem.Load(childName);
        
        if (saveString != null) {
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            
            //Set the Loded things
            childScale = new Vector3(saveObject.childSizePH, saveObject.childSizePH, saveObject.childSizePH);
            this.transform.localScale = childScale;

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
