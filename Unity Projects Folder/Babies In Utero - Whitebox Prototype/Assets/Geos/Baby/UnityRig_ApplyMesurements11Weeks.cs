using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityRig_ApplyMesurements11Weeks : MonoBehaviour
{
    [Header("Measurements")]
    public bool centOnInchOff;
    public float headToRump;
    //public float headCircumference;
    public float headMajorDiameter;
    public float headMinorDiameter;
    public float armLength;
    public float legLength;
    [Header("Body Parts")]
    public GameObject Spine01_Joint;
    public GameObject Spine02_Joint;
    public GameObject Spine03_Joint;
    public GameObject Neck01_Joint;
    public GameObject Neck02_Joint;
    //public GameObject Head_Joint;
    public GameObject LClav_Joint;
    public GameObject LArm01_Joint;
    public GameObject LArm02_Joint;
    public GameObject LArm03_Joint;
    public GameObject RClav_Joint;
    public GameObject RArm01_Joint;
    public GameObject RArm02_Joint;
    public GameObject RArm03_Joint;
    public GameObject Pelvis_Joint;
    public GameObject LLeg01_Joint;
    public GameObject LLeg02_Joint;
    public GameObject LLeg03_Joint;
    public GameObject RLeg01_Joint;
    public GameObject RLeg02_Joint;
    public GameObject RLeg03_Joint;

    public void Update()
    {
        //Pull Measurments

        //Average 27-Week Child Sizes
        float avgHight = 36;
        //float avgHeadCircumference = 44.21f;
        float avgHeadMajorDiameter = 8f;
        float avgHeadMinorDiameter = 6f;
        float avgHeadToRump = (23f-avgHeadMajorDiameter)/4;
        float avgArmLength = 13f/2;
        float avgLegLength = 13f/2;

        //Convert CM into IN
        if (centOnInchOff == false)
        {
            avgHeadToRump = avgHight/2.54f;
            //avgHeadCircumference = avgHeadCircumference/2.54f;
            avgHeadMajorDiameter = avgHeadMajorDiameter/2.54f;
            avgHeadMinorDiameter = avgHeadMinorDiameter/2.54f;
            avgHeadToRump = avgHeadToRump/2.54f;
            avgArmLength = avgArmLength/2.54f;
            avgLegLength = avgLegLength/2.54f;
        }
        
        //Convert Measurments to Unity Units
        //float uHeadCircumference = headCircumference/avgHeadCircumference;
        float uHeadMajorDiameter = headMajorDiameter/avgHeadMajorDiameter;
        float uHeadMinorDiameter = headMinorDiameter/avgHeadMinorDiameter;
        float uHeadToRump = ((headToRump-headMajorDiameter)/4)/avgHeadToRump;
        float uArmLength = (armLength/2)/avgArmLength;
        float uLegLength = (legLength/2)/avgLegLength;

        //Apply Measurments
        HeadToRump(uHeadToRump);
        HeadSize(uHeadMajorDiameter, uHeadMinorDiameter);
        ArmsLength(uHeadToRump, uArmLength);
        LegsLength(uHeadToRump, uLegLength);
    }

    void HeadToRump(float hr)
    {
        Spine01_Joint.transform.localScale = new Vector3(hr, hr, hr);
        Spine02_Joint.transform.localScale = new Vector3(hr, hr, hr);
        Spine03_Joint.transform.localScale = new Vector3(hr, hr, hr);
        Pelvis_Joint.transform.localScale = new Vector3(hr, hr, hr);
        Neck01_Joint.transform.localScale = new Vector3(hr, hr, hr);
        //Neck02_Joint.transform.localScale = new Vector3(hr, hr, hr);
        LClav_Joint.transform.localScale = new Vector3(hr, hr, hr);
        RClav_Joint.transform.localScale = new Vector3(hr, hr, hr);
    }

    void HeadSize(float hdMajor, float hdMinor)
    {
        Neck02_Joint.transform.localScale = new Vector3(hdMajor, hdMajor, hdMinor);
    }

    void ArmsLength(float hr, float al)
    {
        LArm01_Joint.transform.localScale = new Vector3(al, hr, hr);
        LArm02_Joint.transform.localScale = new Vector3(al, hr, hr);
        LArm03_Joint.transform.localScale = new Vector3(hr, hr, hr);
        RArm01_Joint.transform.localScale = new Vector3(al, hr, hr);
        RArm02_Joint.transform.localScale = new Vector3(al, hr, hr);
        RArm03_Joint.transform.localScale = new Vector3(hr, hr, hr);
    }

    void LegsLength(float hr, float ll)
    {
        LLeg01_Joint.transform.localScale = new Vector3(ll, hr, hr);
        LLeg02_Joint.transform.localScale = new Vector3(ll, hr, hr);
        LLeg03_Joint.transform.localScale = new Vector3(hr, hr, hr);
        RLeg01_Joint.transform.localScale = new Vector3(ll, hr, hr);
        RLeg02_Joint.transform.localScale = new Vector3(ll, hr, hr);
        RLeg03_Joint.transform.localScale = new Vector3(hr, hr, hr);
    }
}
