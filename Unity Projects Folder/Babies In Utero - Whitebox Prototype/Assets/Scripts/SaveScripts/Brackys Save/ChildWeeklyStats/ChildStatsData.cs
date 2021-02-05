using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class ChildStatsData
{
    //public string chlidID;
    public string chlidName;
    public float childSize;

    public ChildStatsData (ChildStatsBinary childStatsBinary) {
        //chlidID = childStatsBinary.chlidID;
        chlidName = childStatsBinary.chlidName;
        childSize = childStatsBinary.childSize;
        
    }
}
