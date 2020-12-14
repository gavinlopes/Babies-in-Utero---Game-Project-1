using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpdateDropdownOnStart : MonoBehaviour
{
    //[SerializeField] UnityEvent OnStartEvent;
    public DropDown_SO dropDownSO;
    public GameObject DropdownGO;


    // Start is called before the first frame update
    void Start()
    {
        //OnStartEvent.Invoke();
        DropdownGO.GetComponent<Dropdown>().value = dropDownSO.DropdownIndex;
    }
}
