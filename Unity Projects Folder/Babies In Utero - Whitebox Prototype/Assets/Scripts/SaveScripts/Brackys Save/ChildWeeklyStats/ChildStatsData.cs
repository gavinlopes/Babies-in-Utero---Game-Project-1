using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class ChildStatsData
{
    //
    public string chlidName;
    public int childSex; // 0 = Unknown, 1 = Boy, 2 = Girl

    //public int[] dueDate = new int[3]; //[0]=day, [1]=month, [2]=year
    //public int[] birthDate = new int[3]; //[0]=day, [1]=month, [2]=year
    public string dueDate;
    public string birthDate;

    public bool CmOrIn; //Cm Or In

    static int totalWeeks = 3;
    public bool[] setUpWeek = new bool[totalWeeks]; //This is to indicate whether or not the week has had settings saved to it
    public float[] headDiameterMajor = new float[totalWeeks];
    public float[] headDiameterMinor = new float[totalWeeks];
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
            //dueDate[i] = childStatsBinary.dueDate[i];
            //birthDate[i] = childStatsBinary.birthDate[i];
            dueDate = childStatsBinary.dueDate;
            birthDate = childStatsBinary.birthDate;
        }

        //Measurments
        CmOrIn = childStatsBinary.CmOrIn; //Cm Or In

        //Weekly Stats
        for (int i = 0; i < totalWeeks; i++)
        {
            setUpWeek[i] = childStatsBinary.setUpWeek[i];
            headDiameterMajor[i] = childStatsBinary.headDiameterMajor[i];
            headDiameterMinor[i] = childStatsBinary.headDiameterMinor[i];
            headRumpLength[i] = childStatsBinary.headRumpLength[i];
            armLength[i] = childStatsBinary.armLength[i];
            legLength[i] = childStatsBinary.legLength[i];
        }
    }
}
