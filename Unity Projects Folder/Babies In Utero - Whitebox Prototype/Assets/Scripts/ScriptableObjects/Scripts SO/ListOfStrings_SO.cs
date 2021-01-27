using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
