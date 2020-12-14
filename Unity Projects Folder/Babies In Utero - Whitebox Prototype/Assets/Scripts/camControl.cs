using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
	public Bool_SO boolSO;

    private Vector2 mD;
	private Transform myBody;
	
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
        Vector2 mC = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		mD += mC;
		
		this.transform.localRotation = Quaternion.AngleAxis (-mD.y, Vector3.right);
		
		myBody.localRotation = Quaternion.AngleAxis (mD.x, Vector3.up);
		
        mD.y = Mathf.Clamp(mD.y, -90, 90);
        mD.x = Mathf.Clamp(mD.x, -90, 90);
    }
    
}
