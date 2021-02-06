using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class ChildStatsData
{
    //
    public string chlidName;
    public string childSex; // 0 = Unknown, 1 = Boy, 2 = Girl

    public int[] dueDate = new int[3]; //[0]=day, [1]=month, [2]=year
    public int[] birthDate = new int[3]; //[0]=day, [1]=month, [2]=year

    public float childSize; //Test

    static int totalWeeks = 52;
    public float[] headDiameter = new float[totalWeeks];
    public float[] headCircumference = new float[totalWeeks];
    public float[] headRumpLength = new float[totalWeeks];
    public float[] armLength = new float[totalWeeks];
    public float[] legLength = new float[totalWeeks];
    
    //Spicific to child Game Settings
    public bool viewFullDevelopment; //Full development = True, View 1 Week = False
    public int viewingWeek;


    public ChildStatsData (ChildStatsBinary childStatsBinary) {
        //Name and Sex
        chlidName = childStatsBinary.chlidName;
        childSex = childStatsBinary.childSex; 
        
        //Dates
        for (int i = 0; i < 3; i++)
        {
            dueDate[i] = childStatsBinary.dueDate[i];
            birthDate[i] = childStatsBinary.birthDate[i];
        }

        //Delete this one later
        childSize = childStatsBinary.childSize; //Test

        //Weekly Stats
        for (int i = 0; i < totalWeeks; i++)
        {
            headDiameter[i] = childStatsBinary.headDiameter[i];
            headCircumference[i] = childStatsBinary.headCircumference[i];
            headRumpLength[i] = childStatsBinary.headRumpLength[i];
            armLength[i] = childStatsBinary.armLength[i];
            legLength[i] = childStatsBinary.legLength[i];
        }
    }
}
