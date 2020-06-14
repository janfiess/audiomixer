using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncAudioLayers : MonoBehaviour
{
    int numChildren;
    AudioSource masterclip;
    AudioSource[] slaveClips;
   
    void Start()
    {
        numChildren = transform.childCount;
        masterclip = transform.GetChild(0).GetComponent<AudioSource>();

        slaveClips = new AudioSource[numChildren - 1];
        for(int i = 1; i < numChildren;i++){
            slaveClips[i -1] = transform.GetChild(i).GetComponent<AudioSource>();
        }
    }
    void Update()
    {   
        for(int i = 0; i < numChildren - 1; i++){
            slaveClips[i].timeSamples = masterclip.timeSamples;
        }
    }
}
