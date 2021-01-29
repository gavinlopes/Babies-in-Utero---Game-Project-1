using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData
{
    public string testSave;

    public PlayerData (Player player) {
        testSave  = player.GetComponent<InputField>().text;
    }
}