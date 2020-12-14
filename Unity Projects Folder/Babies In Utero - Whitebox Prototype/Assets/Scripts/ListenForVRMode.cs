using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenForVRMode : MonoBehaviour
{
    public Bool_SO boolSO;
    public List<GameObject> vrObj = new List<GameObject>();
    public List<GameObject> notVrObj = new List<GameObject>();
    //public GameObject vrObj;
    //public GameObject notVrObj;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < vrObj.Count; i++)
            {
                vrObj[i].SetActive(boolSO.isTrue);
            }

        for (int i = 0; i < notVrObj.Count; i++)
            {
                notVrObj[i].SetActive(!boolSO.isTrue);
            }
    }

    // Update is called once per frame
    public void UpdateMode()
    {
        for (int i = 0; i < vrObj.Count; i++)
            {
                vrObj[i].SetActive(boolSO.isTrue);
            }

        for (int i = 0; i < notVrObj.Count; i++)
            {
                notVrObj[i].SetActive(!boolSO.isTrue);
            }
    }

}
