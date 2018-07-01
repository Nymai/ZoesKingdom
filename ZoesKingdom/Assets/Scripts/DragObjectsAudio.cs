using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjectsAudio : MonoBehaviour {

    /*
     * AVOID A LOOP SOUND WHEN THE CHARACTER DRAG BOXES
     * It does a check to make sure that the last sound is not playing
     */

    public AudioSource dragAudio;

	// Use this for initialization
	void Start () {
        dragAudio = GetComponent<AudioSource>();
	}
	

    public void AudioCrate(){
        if(!dragAudio.isPlaying){
            dragAudio.Play();
        }
    }


}