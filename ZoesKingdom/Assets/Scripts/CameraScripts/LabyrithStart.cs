using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrithStart : MonoBehaviour {



    /* SWITCH BETWEEN CAMERAS DEPENDING ON THE PLAYER'S NEEDS OF VISION 
     * It's required to set diferent variables from Unity inspector
     */


    public bool enterLab = false;
    Vector3 regularRotCam;
    public GameObject wallOff1;
    public GameObject walOff2;


    //It's activated at the time of entry when an object passes through
    private void OnTriggerEnter(Collider other)
    {
        if(enterLab){
            if (other.tag == "Player")
            {
                regularRotCam = new Vector3(Camera.main.transform.rotation.x, Camera.main.transform.rotation.y, Camera.main.transform.rotation.z);
                FindObjectOfType<CameraManager>().enabled = false;
                FindObjectOfType<CameraLabyrinth>().enabled = true;
                Camera.main.transform.position = new Vector3(0.11f, 52.0f, 112.4f);
                Camera.main.transform.rotation = Quaternion.LookRotation(Vector3.down);
            }
        }else{
            if (other.tag == "Player")
            {
                FindObjectOfType<CameraManager>().enabled = true;
                FindObjectOfType<CameraLabyrinth>().enabled = false;
                Camera.main.transform.rotation = Quaternion.LookRotation(regularRotCam);
                wallOff1.SetActive(false);
                walOff2.SetActive(false);
            }
        }
    }

}