using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollector : MonoBehaviour {

    /*
     * ADD KEYS TO GAMEMANAGER WHEN INTERACT WITH THE MAIN CHARACTER
     */

    public GameObject accessLevel;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            FindObjectOfType<AudioManager>().AudioKey();


            FindObjectOfType<GameManager>().AddKey();

            if(accessLevel.activeSelf){
                accessLevel.SetActive(false);
            }else{
                accessLevel.SetActive(true);
            }


            Destroy(gameObject);
        }
    }


}