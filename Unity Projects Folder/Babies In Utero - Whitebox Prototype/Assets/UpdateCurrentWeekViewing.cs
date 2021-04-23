using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCurrentWeekViewing : MonoBehaviour
{
    public GameObject saveSystemController;

    static int totalWeeks = 3;
    public GameObject[] weekUnityRig = new GameObject[totalWeeks];

    public GameObject babyCam;
    public GameObject[] camAnchor = new GameObject[totalWeeks];

    void Start() {
        UpdateWeeks();
    }

    // Update is called once per frame
    public void UpdateWeeks()
    {
        for (int i = 0; i < totalWeeks; i++)
        {
             weekUnityRig[i].SetActive(false);
        }
        
        weekUnityRig[saveSystemController.GetComponent<ChildStatsBinary>().viewingWeek].SetActive(true);
        babyCam.transform.parent = camAnchor[saveSystemController.GetComponent<ChildStatsBinary>().viewingWeek].transform;
        babyCam.transform.localPosition = Vector3.zero;
        babyCam.transform.parent = camAnchor[saveSystemController.GetComponent<ChildStatsBinary>().viewingWeek].transform.parent.parent.parent;
    }
}
