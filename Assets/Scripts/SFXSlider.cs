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
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        sfxSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float SFXLevel) {
        sfxMixer.SetFloat("SFXVolume",SFXLevel);
        PlayerPrefs.SetFloat("SFXVolume",SFXLevel);
    }
}
