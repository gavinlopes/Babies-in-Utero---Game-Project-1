using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

//C:\Users\Nathan E\AppData\LocalLow\DefaultCompany\Babies In Utero - Whitebox Prototype

public class ChildStatsBinary : MonoBehaviour
{
    public String_SO selectedChild;
    //Name and Sex
    public string chlidName;
    public int childSex; // 0 = Unknown, 1 = Boy, 2 = Girl

    //Dates
    //public int[] dueDate = new int[3]; //[0]=day, [1]=month, [2]=year
    //public int[] birthDate = new int[3]; //[0]=day, [1]=month, [2]=year
    public string dueDate;
    public string birthDate;

    //Measurments type
    public bool CmOrIn;

    //Weekly Stats
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


    void Start() {
        int buildIndex = SceneManager.GetActiveScene().buildIndex;
        if (buildIndex!=0) {
            chlidName = selectedChild.currentString;
            LoadSettings();
        }
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
            //dueDate[i] = ChildStatsSaveSystem.LoadSettings(chlidName).dueDate[i];
            //birthDate[i] = ChildStatsSaveSystem.LoadSettings(chlidName).birthDate[i];
            dueDate = ChildStatsSaveSystem.LoadSettings(chlidName).dueDate;
            birthDate = ChildStatsSaveSystem.LoadSettings(chlidName).birthDate;
        }

        //Mesurements
        CmOrIn = ChildStatsSaveSystem.LoadSettings(chlidName).CmOrIn; 

        //Weekly Stats
        for (int i = 0; i < totalWeeks; i++)
        {
            setUpWeek[i] = ChildStatsSaveSystem.LoadSettings(chlidName).setUpWeek[i];
            headDiameterMajor[i] = ChildStatsSaveSystem.LoadSettings(chlidName).headDiameterMajor[i];
            headDiameterMinor[i] = ChildStatsSaveSystem.LoadSettings(chlidName).headDiameterMinor[i];
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

    public void setStatDefults() {
        //Name and Sex
        chlidName = "Default Child";
        childSex = 0;
        
        //Dates
        dueDate = "4/7/2021";
        birthDate = "4/7/2021";

        //Mesurments
        CmOrIn = true; //cm = true

        //Weekly Stats
        /*for (int i = 0; i < totalWeeks; i++)
        {
            //Calculate avrages and put them here
            headDiameterMajor[i] = 8;
            headDiameterMinor[i] = 6;
            headRumpLength[i] = 23;
            armLength[i] = 14;
            legLength[i] = 14;
        }*/
        //Week 11
        headDiameterMajor[0] = 0.933f;
        headDiameterMinor[0] = 0.7f;
        headRumpLength[0] = 2.68f;
        armLength[0] = 1.6f;
        legLength[0] = 1.6f;
        //Week 15
        headDiameterMajor[1] = 3.65f;
        headDiameterMinor[1] = 2.73f;
        headRumpLength[1] = 10.48f;
        armLength[1] = 5.92f;
        legLength[1] = 5.92f;
        //Week 27
        headDiameterMajor[2] = 8;
        headDiameterMinor[2] = 6;
        headRumpLength[2] = 23;
        armLength[2] = 14;
        legLength[2] = 14;

    }

    void setNewChild() {
        //Name and Sex
        chlidName = "Child ";
        childSex = 0;
        CmOrIn = true;
        
        //Dates
        /*for (int i = 0; i < 3; i++)
        {
            dueDate[i] = 0;
            birthDate[i] = 0;
        }*/
        dueDate = "Unknown";
        birthDate = "Unkown";

        //Weekly Stats
        /*for (int i = 0; i < totalWeeks; i++)
        {
            headDiameterMajor[i] = -1;
            headDiameterMinor[i] = -1;
            headRumpLength[i] = -1;
            armLength[i] = -1;
            legLength[i] = -1;
        }*/
        
        //Week 11
        headDiameterMajor[0] = 0.933f;
        headDiameterMinor[0] = 0.7f;
        headRumpLength[0] = 2.68f;
        armLength[0] = 1.6f;
        legLength[0] = 1.6f;
        //Week 15
        headDiameterMajor[1] = 3.65f;
        headDiameterMinor[1] = 2.73f;
        headRumpLength[1] = 10.48f;
        armLength[1] = 5.92f;
        legLength[1] = 5.92f;
        //Week 27
        headDiameterMajor[2] = 8;
        headDiameterMinor[2] = 6;
        headRumpLength[2] = 23;
        armLength[2] = 14;
        legLength[2] = 14;

    }
}
