using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DropDown_SO", menuName = "Data Types SO/DropDown_SO", order = 0)]
public class DropDown_SO : ScriptableObject 
{
    public int DropdownIndex;
    public void UpdateIndex (int i)
    {
        DropdownIndex = i;
    }
}