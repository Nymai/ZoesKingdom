using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroOut : MonoBehaviour {

    /* CHANGE TO ANOTHER SCENE IN THE PLAY AFTER AN ENTIRE NUMBER OF MINUTES 
     * It's required that both scenes were added in Scenes in build
     * File > Build Settings > Scenes In Build
     */

    /*
     * Variables
     * all public variables are accessed from Unity inspector
     * all private variables are accessed only from the function or class where are declared
     */

    public int sceneNumber;
    public int secondsToWait;

    // Use this for initialization
    // Call the coroutine to run the function to change the scene
    void Start()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(secondsToWait);
        SceneManager.LoadScene(sceneNumber);

    }
}
