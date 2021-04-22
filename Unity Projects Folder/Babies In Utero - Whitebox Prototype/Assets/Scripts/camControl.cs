using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
	public Bool_SO boolSO;

    private Vector2 mD;
	private Transform myBody;

    //public float speed = 3.5f;

    private float firstX;
    private float firstY;
    private float lastX;
    private float lastY;
    private float currentX;
    private float currentY;

    public float X;
    private float Y;
	
    void Start()
    {
        if (boolSO.isTrue == true)
        {
            enabled = false;
        }
        myBody = this.transform.parent.transform;
    }

    /*void Update()
    {
        if(Input.GetMouseButton(0)) 
        {
            Vector2 mC = new Vector2 (-Input.GetAxisRaw ("Mouse X") * speed, -Input.GetAxisRaw ("Mouse Y") * speed);
            mD += mC;
            
            this.transform.localRotation = Quaternion.AngleAxis (-mD.y, Vector3.right);
            
            myBody.localRotation = Quaternion.AngleAxis (mD.x, Vector3.up);
        }
        mD.y = Mathf.Clamp(mD.y, -90, 90);
        mD.x = Mathf.Clamp(mD.x, -90, 90);
    }*/

    /*void Update()
    {
        Vector2 mC = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		mD += mC;
		
		this.transform.localRotation = Quaternion.AngleAxis (-mD.y, Vector3.right);
		
		myBody.localRotation = Quaternion.AngleAxis (mD.x, Vector3.up);
		
        mD.y = Mathf.Clamp(mD.y, -90, 90);
        mD.x = Mathf.Clamp(mD.x, -90, 90);
    }*/

    void Update() 
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Input.mousePosition;
            firstX = mousePos.x;
            firstY = mousePos.y;

            //Debug.Log("X = " + firstX);
            //Debug.Log("Y = " + firstY);
        }

        if (Input.GetMouseButton(0)) {
            Vector3 mousePos = Input.mousePosition;
            lastX = mousePos.x;
            lastY = mousePos.y;

            X = (firstX - lastX)/5;
            Y = (firstY - lastY)/5;
            //this.transform.rotation = Quaternion.Euler(-Y, X, 0);

            Y = Mathf.Clamp(Y, -80, 80);
            X = Mathf.Clamp(X, -80, 80);

            this.transform.localRotation = Quaternion.Euler(-Y, X, 0);

            //Debug.Log(this.transform.rotation.x);
            //Debug.Log(this.transform.localEulerAngles);
            
        }
        
    }
    
}
