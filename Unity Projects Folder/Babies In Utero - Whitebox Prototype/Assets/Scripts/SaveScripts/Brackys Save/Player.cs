using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //public string testSave = "empty";

    public void SavePlayer () {
        BrackysSaveSystem.SavePlayer(this);
    }

    public void LoadPlayer () {
        PlayerData data = BrackysSaveSystem.LoadPlayer();
        this.GetComponent<InputField>().text = data.testSave;
    }
}
