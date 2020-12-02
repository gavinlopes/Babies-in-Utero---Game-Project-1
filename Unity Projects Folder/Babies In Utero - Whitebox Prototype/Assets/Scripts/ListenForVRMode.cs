using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenForVRMode : MonoBehaviour
{
    public Bool_SO boolSO;
    public GameObject vrObj;
    public GameObject notVrObj;
    
    // Start is called before the first frame update
    void Start()
    {
        vrObj.active = boolSO.isTrue;
        notVrObj.active = !boolSO.isTrue;
    }

    // Update is called once per frame
    public void UpdateMode()
    {
        vrObj.active = boolSO.isTrue;
        notVrObj.active = !boolSO.isTrue;
    }
}
