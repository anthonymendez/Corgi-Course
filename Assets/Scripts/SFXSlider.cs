using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFXSlider : MonoBehaviour {

    public AudioMixer sfxMixer;
    Slider sfxSlider;

    void Start() {
        sfxSlider = GetComponent<Slider>();

        sfxSlider.onValueChanged.AddListener(setVolume);
    }

    public void setVolume(float SFXLevel) {
        sfxMixer.SetFloat("SFXVolume",SFXLevel);
    }
}
