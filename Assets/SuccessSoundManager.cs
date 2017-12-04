using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessSoundManager : MonoBehaviour {

    public AudioClip MusicClip;
    private AudioSource MusicSource;

    // Use this for initialization
    void Start () {
        MusicSource = GetComponent<AudioSource>();
        MusicSource.clip = MusicClip;

    }
	
    public void playSound()
    {
        MusicSource.Play();
    }
}
