using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class MusicController : MonoBehaviour {
    

	// Use this for initialization
	void Start () {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
		
	}
	
	// Update is called once per frame
	void Update () {

        AudioSource audio = GetComponent<AudioSource>();

        if (CollisionDetection.gameOver == true)
        {
            audio.Stop();
        }
            
        if (GameOverMenu.GamePaused == true)
        {
            audio.Pause();
        }

        if (GameOverMenu.GamePaused == false && audio.isPlaying == false)
        {
            audio.Play();
        }
	}
}
