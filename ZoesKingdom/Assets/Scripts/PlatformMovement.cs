using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    /*
     * CONTROL THE MOVEMENT OF MOBILE PLATFORM AND THE COLLISION WITH THE MAIN CHARACTER
     */

    public GameObject Player;

    public float speedPlatform;
    public float minRange;
    public float maxRange;

    private bool near;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z <= minRange)
        {
            near = true;
        }
        else if (transform.position.z >= maxRange)
        {
            near = false;
        }

        if (near)
        {
            transform.position += Vector3.forward * speedPlatform * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.back * speedPlatform * Time.deltaTime;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player){
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Player){
            Player.transform.parent = null;
        }
    }



}