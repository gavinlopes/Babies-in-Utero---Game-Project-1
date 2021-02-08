using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Int_SO", menuName = "Data Types SO/Int_SO", order = 0)]
//NOTE that a int is NOT for decimal places

public class Int_SO : ScriptableObject
{
    //public Object Int_SO;
    public int currentInt;

    public void UpdateInt(int v)
    {
        currentInt = v;
    }

    public void OnValidate() {
         Debug.Log(Time.time);
     }
}
