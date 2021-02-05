using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(fileName = "ListOfStrings_SO", menuName = "ListsAndArrays SO/ListOfStrings_SO", order = 0)]
public class ListOfStrings_SO : ScriptableObject
{
    public List<string> mylist = new List<string>();

    public void AddToEnd(string stringCheck) {
        mylist.Add(stringCheck);
    }    
    
    public void RemoveString(string stringCheck) {
        mylist.Remove(stringCheck);
    }

    public void ChangeSize(int size) {
        //Resize(mylist, size);
    }

}
