using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddNewChildButton : MonoBehaviour
{
    // For adding buttons to ContentParent in Hierarchy
    public GameObject ButtonToAdd;
    public GameObject AddChildButton;
    public ListOfStrings_SO ChildOrderList;

    // UI GameObjects that hold New Child Stats
    public GameObject addingChildName;
    public GameObject addingChildSize;

    private void Awake()
    {
        //Initualize Save System into code
        SaveSystem.Init();
    }

    public void AddToParent()
    {
        //Check if child exists?

        //Create and store new button inside var
        GameObject newButton = Instantiate(ButtonToAdd, transform.position, Quaternion.identity, GameObject.Find("ContentParent").transform);
        int thisIndex = AddChildButton.transform.GetSiblingIndex();
        string childNameString = addingChildName.GetComponent<InputField>().text;

        newButton.transform.SetSiblingIndex(thisIndex);
        newButton.GetComponent<ChildButtonParented>().childName = childNameString;
        newButton.SetActive(true);

        //Create Child Json Save .txt
        SaveNewChild();

        //Add New child to order list
        ChildOrderList.AddToEnd(childNameString);

        
        //This helps figure out the names of the components attached to an object
        /*Component[] components = addingChildName.GetComponents(typeof(Component));
        foreach(Component component in components) {
            Debug.Log("This is the type of component " + component.ToString());
        }*/
        
    }

    private void SaveNewChild() {
        //Get things to Save
        string childName = addingChildName.GetComponent<InputField>().text;
        float childSizePH = float.Parse(addingChildSize.GetComponent<InputField>().text);
        
        SaveObject saveObject = new SaveObject {
            childName = childName,
            childSizePH = childSizePH
        };
        string json = JsonUtility.ToJson(saveObject);
        SaveSystem.Save(json, childName);

        Debug.Log("Saved! Name: " + childName + ", Size: " + childSizePH);
    }

    // Save Object
    private class SaveObject {
        public string childName;
        public float childSizePH;
    }
}
