using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "String_SO", menuName = "Data Types SO/String_SO", order = 0)]

public class String_SO : ScriptableObject
{
    //public Object String;
    public string currentString;

    public void UpdateInt(string v)
    {
        currentString = v;
    }

    public void OnValidate() {
         Debug.Log(Time.time);
     }
}
