using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    /*
     * MANAGE CONTROL MAIN CHARACTER
     * It makes the movement with player inputs and drives the object push
     */

    /*
     * Variables
     * all public variables are accessed from Unity inspector
     * all private variables are accessed only from the function or class where are declared
     */

    public CharacterController controller;
    public Animator anim;


    public float moveSpeed;
    public float walkingSpeed;
    public float runningSpeed;
    public float gravityScale;
    public float jumpSpeed;
    public float pushPower;

    public float turningSpeed;

    private Vector3 movement = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        //pick up the character with the help of its controller
        controller = GetComponent<CharacterController>();

        //pick up the animator component
        anim = GetComponent<Animator>();

        //rotate the character facing the cam at the beginnig
        transform.rotation = Quaternion.LookRotation(Vector3.back);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Z)){
            moveSpeed = runningSpeed;
            anim.SetBool("isRunning", true);
        }else{
            moveSpeed = walkingSpeed;
            anim.SetBool("isRunning", false);
        }

        //moving in x and z axis
        movement.x = Input.GetAxis("Horizontal") * moveSpeed;
        movement.z = Input.GetAxis("Vertical") * moveSpeed;

        //gravity
        movement.y -= gravityScale;

        if (controller.isGrounded)
        {
            movement.y = 0f;

            //jumping
            if (Input.GetButton("Jump"))
            {
                movement.y = jumpSpeed;
                anim.SetBool("isJumping", true);
            }else{
                anim.SetBool("isJumping", false);
            }
        }

        //change the character rotation depending on its direction
        Vector3 inputDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 v = inputDir.normalized;
        v.x = Mathf.Round(v.x);
        v.z = Mathf.Round(v.z);
        if (v.sqrMagnitude > 0.1f)
        {
            Vector3 rotationCharacter = v.normalized;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(rotationCharacter), Time.deltaTime * turningSpeed);
        }


        //using deltaTime to control the time between frames, so it's sure that the scene runs exactly in the same way on any device regardless the frame rate
        controller.Move(movement * Time.deltaTime);

        //change the animation options
        anim.SetFloat("isMoving", (Mathf.Abs(Input.GetAxis("Vertical"))) + (Mathf.Abs(Input.GetAxis("Horizontal"))));

        //control the pushing
        if(anim.GetBool("isPushing")){
            if (Mathf.Abs(Mathf.Round(movement.x)) < Mathf.Epsilon && Mathf.Abs(Mathf.Round(movement.z)) < Mathf.Epsilon)
                anim.SetBool("isPushing", false);
        }



    }

    //push objects with rigidbody
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        pushPower = moveSpeed/2;

        //no rigidbody
        if (body == null || body.isKinematic)
       
            return;
        
            
        //we don't want to push objects below us
        if (hit.moveDirection.y < -0.3f)
            
            return;

        //calculate push direction from move direction, never up or down
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        //apply the push
        body.velocity = pushDir * pushPower;

        if(hit.collider.tag == "Barrel"){
            FindObjectOfType<AudioManager>().AudioBarrel();
        }else if(hit.collider.tag == "Crate"){
            FindObjectOfType<AudioManager>().AudioCrate();
        }

        anim.SetBool("isPushing", true);
    }
        
}