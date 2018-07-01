using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    /*
     * RETURN THE MAIN CHARACTER TO A CONTROL POINT IF PLAYER FALLS TO THE ABYSS
     */

    //variables
    public Transform player;
    public Transform respawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other){

        if(other.tag == "Player"){
            player.transform.position = respawnPoint.transform.position;
        }else{
            Destroy(other.gameObject);
        }
        		
	}
}