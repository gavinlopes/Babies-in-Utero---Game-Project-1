using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
	public Bool_SO boolSO;

    private Vector2 mD;
	private Transform myBody;

    public float speed = 3.5f;
    //private float X;
    //private float Y;
	
    void Start()
    {
        if (boolSO.isTrue == true)
        {
            enabled = false;
        }
        myBody = this.transform.parent.transform;
    }

    void Update()
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
    }

    /*void Update()
    {
        Vector2 mC = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		mD += mC;
		
		this.transform.localRotation = Quaternion.AngleAxis (-mD.y, Vector3.right);
		
		myBody.localRotation = Quaternion.AngleAxis (mD.x, Vector3.up);
		
        mD.y = Mathf.Clamp(mD.y, -90, 90);
        mD.x = Mathf.Clamp(mD.x, -90, 90);
    }*/
    
    /*void Update() 
    {
        if(Input.GetMouseButton(0)) 
        {
            transform.Rotate(new Vector3(Input.GetAxisRaw("Mouse Y") * speed, -Input.GetAxisRaw("Mouse X") * speed, 0));
            X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(X, Y, 0);

            
        }
        
        Y = Mathf.Clamp(Y, 0, 0);
        X = Mathf.Clamp(X, 0, 0);
    }*/
    
}
