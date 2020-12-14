 using UnityEngine;
 using System.Collections;
 public class ReiniciaGCSDK : MonoBehaviour 
 {
     //private GvGvrViewer gr;
     void Start () 
     {
         //gr = new GvrViewer();
     }
 
     void Update () 
     {
         if (Input.GetKey ("joystick button 6")) 
         {
             //gr.Recenter ();
             print ("Restart :D");
         }
 
     }
}