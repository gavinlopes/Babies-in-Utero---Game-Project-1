using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityRig_ApplyMesurements : MonoBehaviour
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
    public GameObject Spine01_Scale;
    public GameObject Spine02_Scale;
    public GameObject Spine03_Scale;
    public GameObject Neck01_Scale;
    public GameObject Neck02_Scale;
    public GameObject Head_Scale;
    public GameObject LClav_Scale;
    public GameObject LArm01_Scale;
    public GameObject LArm02_Scale;
    public GameObject LArm03_Scale;
    public GameObject RClav_Scale;
    public GameObject RArm01_Scale;
    public GameObject RArm02_Scale;
    public GameObject RArm03_Scale;
    public GameObject Pelvis_Scale;
    public GameObject LLeg01_Scale;
    public GameObject LLeg02_Scale;
    public GameObject LLeg03_Scale;
    public GameObject RLeg01_Scale;
    public GameObject RLeg02_Scale;
    public GameObject RLeg03_Scale;

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
        Spine01_Scale.transform.localScale = new Vector3(hr, hr, hr);
        Spine02_Scale.transform.localScale = new Vector3(hr, hr, hr);
        Spine03_Scale.transform.localScale = new Vector3(hr, hr, hr);
        Pelvis_Scale.transform.localScale = new Vector3(hr, hr, hr);
        Neck01_Scale.transform.localScale = new Vector3(hr, hr, hr);
        Neck02_Scale.transform.localScale = new Vector3(hr, hr, hr);
        LClav_Scale.transform.localScale = new Vector3(hr, hr, hr);
        RClav_Scale.transform.localScale = new Vector3(hr, hr, hr);
    }

    void HeadSize(float hdMajor, float hdMinor)
    {
        Head_Scale.transform.localScale = new Vector3(hdMajor, hdMajor, hdMinor);
    }

    void ArmsLength(float hr, float al)
    {
        LArm01_Scale.transform.localScale = new Vector3(al, hr, hr);
        LArm02_Scale.transform.localScale = new Vector3(al, hr, hr);
        LArm03_Scale.transform.localScale = new Vector3(hr, hr, hr);
        RArm01_Scale.transform.localScale = new Vector3(al, hr, hr);
        RArm02_Scale.transform.localScale = new Vector3(al, hr, hr);
        RArm03_Scale.transform.localScale = new Vector3(hr, hr, hr);
    }

    void LegsLength(float hr, float ll)
    {
        LLeg01_Scale.transform.localScale = new Vector3(ll, hr, hr);
        LLeg02_Scale.transform.localScale = new Vector3(ll, hr, hr);
        LLeg03_Scale.transform.localScale = new Vector3(hr, hr, hr);
        RLeg01_Scale.transform.localScale = new Vector3(ll, hr, hr);
        RLeg02_Scale.transform.localScale = new Vector3(ll, hr, hr);
        RLeg03_Scale.transform.localScale = new Vector3(hr, hr, hr);
    }
}
