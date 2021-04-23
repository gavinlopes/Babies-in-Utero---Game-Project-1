using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LookAtForSecond : MonoBehaviour
{
    public Color inactive;
    public Color gazedAt;

    private SpriteRenderer myRenderer;
    private bool colorChanging = false;
    private float myTimer = 0;

    public UnityEvent TriggerThis;

    public void GazeAt(bool gazing) 
    {
        if (gazing) {
            colorChanging = true;
        } else {
            myTimer = 0;
            colorChanging = false;
            myRenderer.material.color = inactive;
        }
    }

    private void Start() 
    {
        myRenderer = GetComponent<SpriteRenderer>();
        myRenderer.material.color = inactive;
    }

    // Update is called once per frame
    void Update()
    {
        if (colorChanging) {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, gazedAt, Time.deltaTime/0.5f);
            myTimer += Time.deltaTime;
            if (myTimer >= 1) {
                colorChanging = false;
                myRenderer.material.color = inactive;
                myTimer = 0;
                TriggerThis.Invoke();
            }
        }
    }
}
