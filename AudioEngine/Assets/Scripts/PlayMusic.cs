using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;



public class PlayMusic : MonoBehaviour
{
    public AudioMixerSnapshot audioMixerSnapshot_fullVol, audioMixerSnapshot_halfVol, audioMixerSnapshot_mute;
    public float fadeTime = 1.0f;
    // public float delayTime = 0.0f;
    int playbackProgress = 0;
    //int toggle_playpause = 0;
    public List<AudioClip> tracksForLayer;
    AudioSource myAudioSource;
    int buttonClickNum;
    

    void Awake() {
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.clip = tracksForLayer[0];
        myAudioSource.Play();
    }

    // Button Interaction -> to be removed when there are no buttons any more.
    public void ControlLayerVolume()
    {
        buttonClickNum +=1;
        buttonClickNum %=3;

        if(buttonClickNum == 0){
            Layer1_mute();
        }

        if(buttonClickNum == 1){
            Layer1_fullVol();
        }

        if(buttonClickNum == 2){
            Layer1_halfVol();
        }
    }

    public void Layer1_fullVol(){
        print("full");
        audioMixerSnapshot_fullVol.TransitionTo (fadeTime);
    }

    public void Layer1_mute(){
        print("mute");
        audioMixerSnapshot_mute.TransitionTo (fadeTime);
    }

    public void Layer1_halfVol(){
        print("half");
        audioMixerSnapshot_halfVol.TransitionTo (fadeTime);
    }


    void Update() {
        /* 
        if(Input.GetKeyDown(KeyCode.A)){
            toggle_playpause += 1;
            toggle_playpause %= 2;
            // playbackProgress = audioSource.timeSamples; 
        }
        */
         
    }

    public void SwapClip1(){
        //playbackProgress = myAudioSource.timeSamples;
        myAudioSource.clip = tracksForLayer[0];
        //myAudioSource.timeSamples = playbackProgress;
        myAudioSource.Play();
    }

     public void SwapClip2(){
        //playbackProgress = myAudioSource.timeSamples;
        myAudioSource.clip = tracksForLayer[1];
        //myAudioSource.timeSamples = playbackProgress;
        myAudioSource.Play();
    }

    public void SwapClip3(){
        //playbackProgress = myAudioSource.timeSamples;
        myAudioSource.clip = tracksForLayer[2];
        //myAudioSource.timeSamples = playbackProgress;
        myAudioSource.Play();
    }

    public void SwapClip4(){
        //playbackProgress = myAudioSource.timeSamples;
        myAudioSource.clip = tracksForLayer[3];
        //myAudioSource.timeSamples = playbackProgress;
        myAudioSource.Play();
    }
}
