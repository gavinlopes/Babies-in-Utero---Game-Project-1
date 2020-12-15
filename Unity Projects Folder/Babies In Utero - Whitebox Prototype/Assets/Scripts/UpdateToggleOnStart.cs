using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpdateToggleOnStart : MonoBehaviour
{
    //[SerializeField] UnityEvent OnStartEvent;
    public Bool_SO BoolSO;
    public GameObject ToggleGO;


    // Start is called before the first frame update
    void Start()
    {
        //OnStartEvent.Invoke();
        ToggleGO.GetComponent<ToggleController>().isOn = BoolSO.isTrue;
        ToggleGO.GetComponent<ToggleController>().Start();
    }
}
