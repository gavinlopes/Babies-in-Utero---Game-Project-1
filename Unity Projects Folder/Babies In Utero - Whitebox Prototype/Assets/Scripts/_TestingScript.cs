using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _TestingScript : MonoBehaviour
{
    public class Child {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Size_PH { get; set; }
    }

    //public string[] BBName;

    private void Start() 
    {
        var childList = new List<Child>();
        //public List<string> testList = new List<string>();

        childList.Add( new Child {
            ID = 1,
            Name = "Default Child",
            Size_PH = 1
        });

        childList.Add( new Child {
            ID = 0,
            Name = "1 Child",
            Size_PH = 1
        });
        
        childList.Add( new Child {
            ID = 2,
            Name = "2 Child",
            Size_PH = 1.5f
        });
        
        childList.Add( new Child {
            ID = 0,
            Name = "3 Child",
            Size_PH = 1
        });

        //Child firstChild = childList[0]; 

        //Print tests

        
        /*
        Debug.Log("Slot: " + childList.IndexOf(childList[1]) );

        Debug.Log("ID: " + childList[1].ID);
        Debug.Log("Name: " + childList[1].Name);
        Debug.Log("Size: " + childList[1].Size_PH);

        childList.Remove(childList[1]);

        //Print tests
        Debug.Log("Slot: " + childList.IndexOf(childList[1]) );

        Debug.Log("ID: " + childList[1].ID);
        Debug.Log("Name: " + childList[1].Name);
        Debug.Log("Size: " + childList[1].Size_PH);
        */
    }


}
