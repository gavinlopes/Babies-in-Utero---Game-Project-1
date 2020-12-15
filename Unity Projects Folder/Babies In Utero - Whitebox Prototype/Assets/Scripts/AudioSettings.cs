using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer audioMixer;

    // Update is called once per frame
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volumeParam", volume);
    }
}
