using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollector : MonoBehaviour {

    /*
     * ADD COINS TO GAMEMANAGER WHEN INTERACT WITH MAIN CHARACTER
     * As well manage the pick sound, for this reason is neccesary using a 
     * coroutine to wait the sound ends before destroy the object
     */

    public int coinValue;
    public AudioSource pickUpSound;

	// Use this for initialization
	void Start () {
        pickUpSound = GetComponent<AudioSource>();
	}
	

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Player"){

            pickUpSound.Play();

            FindObjectOfType<GameManager>().AddGold(coinValue);

            StartCoroutine(DestroyCoin());

            //if we destroy the object without a coroutine we cannot listen the audiopick
        //    Destroy(gameObject);
        }
	}

    IEnumerator DestroyCoin(){
        yield return new WaitForSeconds(pickUpSound.clip.length);
        Destroy(gameObject);
    }
}