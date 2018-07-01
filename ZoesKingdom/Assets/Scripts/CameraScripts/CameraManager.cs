using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {


    /* CONTROL THE REGULAR CAMERA  
     * It's required to set diferent variables from Unity inspector
     * Always transform its position in relation to character movement
     */


    public Transform target;            //target to follow
    public Vector3 offset;              //camera distance
    public float speed;
    public float walkingSpeed;
    public float runningSpeed;

    private Transform camTransform;


	// Use this for initialization
	void Start () {
        camTransform = transform;
	}


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            speed = runningSpeed;
        }
        else
        {
            speed = walkingSpeed;
        }
    }


	// LateUpdate is called after Update functions to let the character movement in a right way
	void LateUpdate(){
		
        //if there's a character to follow
        if(target != null){
            camTransform.position = Vector3.Lerp(camTransform.position, target.position + offset, speed * Time.deltaTime);
        }
	}
}