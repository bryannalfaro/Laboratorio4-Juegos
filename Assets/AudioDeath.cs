using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDeath : MonoBehaviour


{

    public AudioClip death;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deathSound()
    {
        if (death) audio.PlayOneShot(death);
    }
}
