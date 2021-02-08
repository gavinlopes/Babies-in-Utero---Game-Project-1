using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class DoOnGameStart : MonoBehaviour
{
    public GameObject AudioV;
    public GameObject MusicV;

    private void Start() {
        float vol = AudioV.GetComponent<Slider>().value;
        AudioV.GetComponent<AudioSettings>().SetVolume(vol);

        vol = MusicV.GetComponent<Slider>().value;
        MusicV.GetComponent<AudioSettings>().SetVolume(vol);
    }
}
