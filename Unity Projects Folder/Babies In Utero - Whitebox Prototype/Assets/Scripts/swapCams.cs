using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapCams : MonoBehaviour
{
	public GameObject MainReticle;
    
    public Camera PlayerCam;
	public Camera BabyCam;

    public DropDown_SO dropDownSO;
	

    void Start()
    {
        if (dropDownSO.DropdownIndex==0)
        {
            PlayerCam.gameObject.SetActive(true);
            MainReticle.transform.parent = PlayerCam.transform;
            MainReticle.transform.localRotation = Quaternion.identity;
            MainReticle.transform.localPosition = Vector3.zero;
            MainReticle.transform.localScale = Vector3.one;
            MainReticle.GetComponent<GvrReticlePointer>().overridePointerCamera=PlayerCam;
            BabyCam.gameObject.SetActive(false);
        }
        else
        {
            BabyCam.gameObject.SetActive(true);
            MainReticle.transform.parent = BabyCam.transform;
            MainReticle.transform.localRotation = Quaternion.identity;
            MainReticle.transform.localPosition = Vector3.zero;
            MainReticle.transform.localScale = Vector3.one;
            MainReticle.GetComponent<GvrReticlePointer>().overridePointerCamera=BabyCam;
            PlayerCam.gameObject.SetActive(false);
        }
    }

    public void CheckSwap()
    {
        if (dropDownSO.DropdownIndex==0)
        {
            PlayerCam.gameObject.SetActive(true);
            MainReticle.transform.parent = PlayerCam.transform;
            MainReticle.transform.localRotation = Quaternion.identity;
            MainReticle.transform.localPosition = Vector3.zero;
            MainReticle.transform.localScale = Vector3.one;
            MainReticle.GetComponent<GvrReticlePointer>().overridePointerCamera=PlayerCam;
            BabyCam.gameObject.SetActive(false);
        }
        else
        {
            BabyCam.gameObject.SetActive(true);
            MainReticle.transform.parent = BabyCam.transform;
            MainReticle.transform.localRotation = Quaternion.identity;
            MainReticle.transform.localPosition = Vector3.zero;
            MainReticle.transform.localScale = Vector3.one;
            MainReticle.GetComponent<GvrReticlePointer>().overridePointerCamera=BabyCam;
            PlayerCam.gameObject.SetActive(false);
        }
    }

    /*IEnumerator SwitchCams()
    {
        if (dropDownSO.DropdownIndex==0)
        {
            MainReticle.transform.parent = Player.transform;
        }
        else
        {
            MainCam.transform.parent = BabyCam.transform;
        }
    }*/
}
