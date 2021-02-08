using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bool_SO", menuName = "Data Types SO/Bool_SO", order = 0)]
//NOTE that a bool is for true/falce statements

public class Bool_SO : ScriptableObject 
{
    public bool isTrue;

    public void ToTrue()
    {
        isTrue = true;
    }
    public void ToFalse()
    {
        isTrue = false;
    }
    public void BoolSwap()
    {
        isTrue = !isTrue;
    }
    public void DynamicSwap(bool b)
    {
        isTrue = b;
    }
}