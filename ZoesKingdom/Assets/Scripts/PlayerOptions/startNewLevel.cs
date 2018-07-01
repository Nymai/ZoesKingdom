using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startNewLevel : MonoBehaviour {

    /*
     * DETECT WHEN PLAYER IS ARRIVED TO ANOTHER "LEVEL" AND SET DE RECORDS
     */

    public int levelNumber;


	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Player"){
            

            FindObjectOfType<setPlayerOptions>().setPlayerLevel(levelNumber);
            FindObjectOfType<setPlayerOptions>().setPlayerGame(1);
            FindObjectOfType<GameManager>().saveCollection();


            Destroy(gameObject);

        }
	}
}