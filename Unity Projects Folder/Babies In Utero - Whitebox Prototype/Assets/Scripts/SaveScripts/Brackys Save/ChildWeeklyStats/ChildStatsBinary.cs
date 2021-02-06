using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

//C:\Users\Nathan E\AppData\LocalLow\DefaultCompany\Babies In Utero - Whitebox Prototype

public class ChildStatsBinary : MonoBehaviour
{
    //Name and Sex
    public string chlidName;
    public string childSex; // 0 = Unknown, 1 = Boy, 2 = Girl

    //Dates
    public int[] dueDate = new int[3]; //[0]=day, [1]=month, [2]=year
    public int[] birthDate = new int[3]; //[0]=day, [1]=month, [2]=year

    //Test (delete when done with)
    public float childSize; //Test

    //Weekly Stats
    static int totalWeeks = 52;
    public float[] headDiameter = new float[totalWeeks];
    public float[] headCircumference = new float[totalWeeks];
    public float[] headRumpLength = new float[totalWeeks];
    public float[] armLength = new float[totalWeeks];
    public float[] legLength = new float[totalWeeks];

    //Spicific to child Game Settings
    public bool viewFullDevelopment; //Full development = True, View 1 Week = False
    public int viewingWeek;


    void Start() {
        setStatDefults();
    }

    // Child Stats Data
    public void SaveSettings () {
        ChildStatsSaveSystem.SaveSettings(this, chlidName);
    }

    public void LoadSettings () {
        //Name and Sex
        chlidName = ChildStatsSaveSystem.LoadSettings(chlidName).chlidName;
        childSex = ChildStatsSaveSystem.LoadSettings(chlidName).childSex; 
        
        //Dates
        for (int i = 0; i < 3; i++)
        {
            dueDate[i] = ChildStatsSaveSystem.LoadSettings(chlidName).dueDate[i];
            birthDate[i] = ChildStatsSaveSystem.LoadSettings(chlidName).birthDate[i];
        }

        //Delete this one later
        childSize = ChildStatsSaveSystem.LoadSettings(chlidName).childSize; //Test

        //Weekly Stats
        for (int i = 0; i < totalWeeks; i++)
        {
            headDiameter[i] = ChildStatsSaveSystem.LoadSettings(chlidName).headDiameter[i];
            headCircumference[i] = ChildStatsSaveSystem.LoadSettings(chlidName).headCircumference[i];
            headRumpLength[i] = ChildStatsSaveSystem.LoadSettings(chlidName).headRumpLength[i];
            armLength[i] = ChildStatsSaveSystem.LoadSettings(chlidName).armLength[i];
            legLength[i] = ChildStatsSaveSystem.LoadSettings(chlidName).legLength[i];
        }
    }

    public void DeleteSettings(string chlidID) {
        string path = Application.persistentDataPath + "/_"+ chlidID +"_Stats.sav";
        if (File.Exists(path)) {
            File.Delete(path); 
            Debug.Log("Deleted This!  "+path);
        } else {
            Debug.Log(chlidID + "Stats.sav file not found in " + path);
        }
    }

    void setStatDefults() {
        //Name and Sex
        chlidName = "DefaultChild";
        childSex = "Unknown"; 
        
        //Dates
        dueDate[0] = 7;
        birthDate[0] = 7;
        dueDate[1] = 4;
        birthDate[1] = 4;
        dueDate[2] = 2021;
        birthDate[2] = 2021;

        //Delete this one later
        childSize = 1; //Test

        //Weekly Stats
        for (int i = 0; i < totalWeeks; i++)
        {
            //Calculate avrages and put them here
            headDiameter[i] = -1;
            headCircumference[i] = -1;
            headRumpLength[i] = -1;
            armLength[i] = -1;
            legLength[i] = -1;
        }

    }

    void setNewChild() {
        //Name and Sex
        chlidName = "Child ";
        childSex = "Unknown";
        
        //Dates
        for (int i = 0; i < 3; i++)
        {
            dueDate[i] = 0;
            birthDate[i] = 0;
        }

        //Weekly Stats
        for (int i = 0; i < totalWeeks; i++)
        {
            headDiameter[i] = -1;
            headCircumference[i] = -1;
            headRumpLength[i] = -1;
            armLength[i] = -1;
            legLength[i] = -1;
        }

    }
}
