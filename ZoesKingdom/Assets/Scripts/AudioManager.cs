using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    /*
     * PLAY THE MAIN AUDIO EFFECTS IN THE GAME
     */

    public AudioSource barrelAudio;
    public AudioSource bombAudio;
    public AudioSource crateAudio;
    public AudioSource keyAudio;


    //barrel movement
    public void AudioBarrel()
    {
        if (!barrelAudio.isPlaying)
        {
            barrelAudio.Play();
        }
    }


    //bomb enemy explotion
    public void AudioBomb()
    {
        bombAudio.Play();
    }


    //crate movement
    public void AudioCrate()
    {
        if (!crateAudio.isPlaying)
        {
            crateAudio.Play();
        }
    }


    //key pick up
    public void AudioKey(){
        keyAudio.Play();
    }
}