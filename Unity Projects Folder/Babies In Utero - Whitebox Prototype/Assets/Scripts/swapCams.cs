using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapCams : MonoBehaviour
{
	public GameObject Player;
	public GameObject BabyCam;
	
	private bool playerBool = true;
	private bool babyBool = false;
	
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
			playerBool = !playerBool;
			babyBool = !babyBool;
			
            Player.SetActive(playerBool);
            BabyCam.SetActive(babyBool);
        }
    }
}
