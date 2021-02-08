using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatSlider_SO", menuName = "Data Types SO/FloatSlider_SO", order = 0)]
//NOTE that a float is for decimal places

public class FloatSlider_SO : ScriptableObject
{
    //public Object SliderObject;
    public float currentInt;

    public void UpdateInt(float v)
    {
        currentInt = v;
    }

    public void OnValidate() {
         Debug.Log(Time.time);
     }
}
