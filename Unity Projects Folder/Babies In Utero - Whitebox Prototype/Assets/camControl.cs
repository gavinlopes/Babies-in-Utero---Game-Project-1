using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
	private Vector2 mD;
	private Transform myBody;
	
    void Start()
    {
        myBody = this.transform.parent.transform;
    }

    void Update()
    {
        Vector2 mC = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		mD += mC;
		
		this.transform.localRotation = Quaternion.AngleAxis (-mD.y, Vector3.right);
		
		myBody.localRotation = Quaternion.AngleAxis (mD.x, Vector3.up);
		
    }
}
