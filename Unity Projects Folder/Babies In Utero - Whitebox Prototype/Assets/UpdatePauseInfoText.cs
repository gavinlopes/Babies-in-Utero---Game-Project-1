using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePauseInfoText : MonoBehaviour
{

    public GameObject saveSystemController;
    public Text myText;

    // Update is called once per frame
    void Update() {
        int selectedWeek = saveSystemController.GetComponent<ChildStatsBinary>().viewingWeek;

        int sexInt = saveSystemController.GetComponent<ChildStatsBinary>().childSex;
        string dueInfo = saveSystemController.GetComponent<ChildStatsBinary>().dueDate;
        string bornInfo = saveSystemController.GetComponent<ChildStatsBinary>().birthDate;
        float headDMajor = saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMajor[selectedWeek];
        float headDMinor = saveSystemController.GetComponent<ChildStatsBinary>().headDiameterMinor[selectedWeek];

        float hightInfo = saveSystemController.GetComponent<ChildStatsBinary>().headRumpLength[selectedWeek] + saveSystemController.GetComponent<ChildStatsBinary>().legLength[selectedWeek];
        bool cmorinBool = saveSystemController.GetComponent<ChildStatsBinary>().CmOrIn;
       
       string[] sexInfo = new string[3];
       sexInfo[0] = "Suprise!";
       sexInfo[1] = "Boy";
       sexInfo[2] = "Girl";
       
       string CmOrIn;
       if (cmorinBool) {CmOrIn = "cm";} else {CmOrIn = "in";}

       string[] sizeReff = new string[3];
       sizeReff[0] = "Fig";
       sizeReff[1] = "Apple";
       sizeReff[2] = "Cauliflower";
       

       /*
        Unknown
        Apr. 01, 2021
        Apr. 01, 2021


        X.X cm
        X.X cm
        X.X cm
        X.X lb

        Kumquat
        */
        
        string finalText = sexInfo[sexInt] + "\n" + dueInfo + "\n" + bornInfo + "\n \n \n" + headDMajor + CmOrIn + "\n" + headDMinor + CmOrIn + "\n \n" + hightInfo + CmOrIn + "\n \n" + sizeReff[selectedWeek];

        myText.text = finalText;
    }
}