using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
	public float mySpeed;
	
    void Update()
    {
		float movementV = Input.GetAxis("Vertical");
		movementV *= Time.deltaTime;
		movementV *= mySpeed;
		
        this.transform.Translate(Vector3.forward * movementV);
		
		float movementH = Input.GetAxis("Horizontal");
		movementH *= Time.deltaTime;
		movementH *= mySpeed;
		
        this.transform.Translate(Vector3.right * movementH);
    }
}
