using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MUSICSlider : MonoBehaviour {

    public AudioMixer musicMixer;
    Slider musicSlider;

    void Start() {
        musicSlider = GetComponent<Slider>();
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        musicSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float musicLevel) {
        musicMixer.SetFloat("SFXVolume", musicLevel);
        PlayerPrefs.SetFloat("MusicVolume",musicLevel);
    }
}
