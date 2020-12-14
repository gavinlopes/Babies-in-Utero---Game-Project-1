using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpdateSliderOnStart : MonoBehaviour
{
    //[SerializeField] UnityEvent OnStartEvent;
    public FloatSlider_SO FloatSliderSO;
    public GameObject SliderGO;


    // Start is called before the first frame update
    void Start()
    {
        //OnStartEvent.Invoke();
        SliderGO.GetComponent<Slider>().value = FloatSliderSO.currentInt;
    }
}
