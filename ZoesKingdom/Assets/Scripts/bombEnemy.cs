using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombEnemy : MonoBehaviour {

    /*
     * CONTROL BOMBER ENEMY MOVEMENT AND THE INTERACTION WITH THE MAIN CHARACTER 
     */

    public float speedEnemy;
    public float minRange;
    public float maxRange;


    private bool near;

    public GameObject explosionEffect;
    public Transform respawnPoint;

	// Update is called once per frame
	void Update () {
        if (transform.position.x <= minRange)
        {
            near = true;
        }
        else if (transform.position.x >= maxRange)
        {
            near = false;
        }

        if (near)
        {
            transform.position += Vector3.right * speedEnemy * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * speedEnemy * Time.deltaTime;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("BOMB");

            Instantiate(explosionEffect, transform.position, transform.rotation);

            FindObjectOfType<AudioManager>().AudioBomb();
            FindObjectOfType<GameManager>().AddGold(-5);

            other.transform.position = respawnPoint.transform.position;


            Destroy(gameObject);
        }
    }


}