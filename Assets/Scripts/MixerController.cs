﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/*
 * Bryann Alfaro
 * Clase que controla el volumen del slider
 */
public class MixerController : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel (float sliderValue){

        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue)*20);
    
    }
}
