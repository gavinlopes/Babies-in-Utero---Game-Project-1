using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    string GetChildName();
    void SetChildName(string childName);

    float GetChildSizePH();
    void SetChildSizePH(float childSize);

    Vector3 GCS();
    
}
