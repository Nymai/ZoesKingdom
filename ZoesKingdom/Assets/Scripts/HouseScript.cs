using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseScript : MonoBehaviour {

    /*
     * MANAGE THE SUCCESS OF THE GAME
     * Checking the number of collected keys and calling the last scene
     */

    public GameManager key;
    public Transform player;
    public Transform respawnPoint;

    public int secondsToWait;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(key.currentKeys >= 3){
                Debug.Log("HAS GANADO");
                StartCoroutine(ChangeScene());

                FindObjectOfType<GameManager>().saveCollection();

            }else{
                Debug.Log("SIGUE BUSCANDO LLAVES");
                player.transform.position = respawnPoint.transform.position;
            }

        }

    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(secondsToWait);
        SceneManager.LoadScene(4);

    }


}