using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadAllChildrenInvintory : MonoBehaviour
{
    // For adding buttons to ContentParent in Hierarchy
    public GameObject ButtonToDuplicate;
    public GameObject LastButtonInList;
    public ListOfStrings_SO ChildOrderList;

    //
    //string SAVE_FOLDER = Application.dataPath + "/Resources/";

    // Start is called before the first frame update
    void Awake()
    { 
        foreach(string i in ChildOrderList.mylist) {
            AddChildButton(i);
        }


        // Check for any .txt files for children saves
        /*List<string> myClearList = new List<string>();
        
        foreach(string i in ChildOrderList.mylist) {
            if (File.Exists(SAVE_FOLDER + i + ".txt")) {
                AddChildButton(i);
            } else {
                myClearList.Add(i);
            }
            
            Debug.Log(SAVE_FOLDER + i + ".txt");
        }

        if (myClearList.Count > 0) {
            foreach(string j in myClearList) {
                ChildOrderList.RemoveString(j);
            }
        }*/
    }

    private void AddChildButton(string childName) {
        //Create and store new button inside var
        GameObject newButton = Instantiate(ButtonToDuplicate, transform.position, Quaternion.identity, GameObject.Find("ContentParent").transform);
        int thisIndex = LastButtonInList.transform.GetSiblingIndex();
        //string childNameString = ChildOrderList.mylist[0];

        newButton.transform.SetSiblingIndex(thisIndex);
        newButton.GetComponent<ChildButtonParented>().childName = childName;
        newButton.SetActive(true);
    }
}
