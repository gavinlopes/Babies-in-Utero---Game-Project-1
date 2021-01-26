using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListOfArrays_SO", menuName = "ListsAndArrays SO/ListOfArrays_SO", order = 0)]
public class ListOfArrays_SO : ScriptableObject
{
    public int numbers;
    
    public string[] Name;
    

    public class Child {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Size_PH { get; set; }
    }
}
