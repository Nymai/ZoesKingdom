using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

    /*
     * CHANGE SCENE AT THE MOMENT
     */

    //change between scenes, the index is numbered on build settings
    public void LoadByIndex (int sceneIndex) {
        SceneManager.LoadScene (sceneIndex);
    }

}