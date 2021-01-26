using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChildButtonParented : MonoBehaviour
{
    public Int_SO selectedChildSO;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.SetParent(GameObject.Find("ContentParent").transform);
        //this.transform.SetSiblingIndex(1);
        
        UpdateChildButton();
    }

    void OnEnable() 
    {
        UpdateChildButton();
    }

    void UpdateChildButton() 
    {
        //Variables
        GameObject buttonText = this.transform.GetChild(0).gameObject;
        int siblingIndex = this.transform.GetSiblingIndex();
        string childName = "Bob";//listThing[siblingIndex].name;

        //Rename object the name of child
        this.name = "Button For " + childName;

        //Update the name of the child on the button
        buttonText.GetComponent<TextMeshProUGUI>().text = childName;
    }

    public void UpdateSelectedChild()
    {
        selectedChildSO.currentInt = this.transform.GetSiblingIndex();
    }
}
