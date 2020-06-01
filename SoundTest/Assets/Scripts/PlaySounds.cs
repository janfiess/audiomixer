using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySounds : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip track;
    public AudioMixerSnapshot audioMixerSnapshot;
    public float fadeTime = 3.0f;
    public float delayTime = 0.0f;

    // public AudioMixerGoup audioMixerGroup;

    int playbackProgress = 0;

    void Start(){
        audioSource = GetComponent<AudioSource>();

    }

    public void PlaySound(){
        if(!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // void Update() {
    //      playbackProgress = audioSource.timeSamples; 
    // }
    


    // public void StartPlay(){
    //     audioSource.clip = track;
    //     audioSource.timeSamples = playbackProgress;
    //     audioSource.Play();
    // }

    // public void Pause(){
    //     playbackProgress = audioSource.timeSamples;
    //     audioSource.Stop();
    // }
}
