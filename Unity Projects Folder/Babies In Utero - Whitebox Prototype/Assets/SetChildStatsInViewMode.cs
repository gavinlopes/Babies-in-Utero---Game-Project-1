using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChildStatsInViewMode : MonoBehaviour
{
    [Header("Weeks")]
    public GameObject Week11;
    public GameObject Week15;
    public GameObject Week27;

    // Start is called before the first frame update
    void Start()
    {
        //Week 11
        Week11.GetComponent<UnityRig_ApplyMesurements11Weeks>().centOnInchOff = this.GetComponent<ChildStatsBinary>().CmOrIn;
        Week11.GetComponent<UnityRig_ApplyMesurements11Weeks>().headToRump = this.GetComponent<ChildStatsBinary>().headRumpLength[0];
        Week11.GetComponent<UnityRig_ApplyMesurements11Weeks>().headMajorDiameter = this.GetComponent<ChildStatsBinary>().headDiameterMajor[0];
        Week11.GetComponent<UnityRig_ApplyMesurements11Weeks>().headMinorDiameter = this.GetComponent<ChildStatsBinary>().headDiameterMinor[0];
        Week11.GetComponent<UnityRig_ApplyMesurements11Weeks>().armLength = this.GetComponent<ChildStatsBinary>().armLength[0];
        Week11.GetComponent<UnityRig_ApplyMesurements11Weeks>().legLength = this.GetComponent<ChildStatsBinary>().legLength[0];

        //Week 15
        Week15.GetComponent<UnityRig_ApplyMesurements15>().centOnInchOff = this.GetComponent<ChildStatsBinary>().CmOrIn;
        Week15.GetComponent<UnityRig_ApplyMesurements15>().headToRump = this.GetComponent<ChildStatsBinary>().headRumpLength[1];
        Week15.GetComponent<UnityRig_ApplyMesurements15>().headMajorDiameter = this.GetComponent<ChildStatsBinary>().headDiameterMajor[1];
        Week15.GetComponent<UnityRig_ApplyMesurements15>().headMinorDiameter = this.GetComponent<ChildStatsBinary>().headDiameterMinor[1];
        Week15.GetComponent<UnityRig_ApplyMesurements15>().armLength = this.GetComponent<ChildStatsBinary>().armLength[1];
        Week15.GetComponent<UnityRig_ApplyMesurements15>().legLength = this.GetComponent<ChildStatsBinary>().legLength[1];
        
        //Week 27
        Week27.GetComponent<UnityRig_ApplyMesurements>().centOnInchOff = this.GetComponent<ChildStatsBinary>().CmOrIn;
        Week27.GetComponent<UnityRig_ApplyMesurements>().headToRump = this.GetComponent<ChildStatsBinary>().headRumpLength[2];
        Week27.GetComponent<UnityRig_ApplyMesurements>().headMajorDiameter = this.GetComponent<ChildStatsBinary>().headDiameterMajor[2];
        Week27.GetComponent<UnityRig_ApplyMesurements>().headMinorDiameter = this.GetComponent<ChildStatsBinary>().headDiameterMinor[2];
        Week27.GetComponent<UnityRig_ApplyMesurements>().armLength = this.GetComponent<ChildStatsBinary>().armLength[2];
        Week27.GetComponent<UnityRig_ApplyMesurements>().legLength = this.GetComponent<ChildStatsBinary>().legLength[2];
    }
}
