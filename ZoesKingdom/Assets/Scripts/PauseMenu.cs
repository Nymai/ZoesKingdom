using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    /*
     * SWITCH BETWEEN PAUSED AND PLAYED GAME MAKING A TIME CHANGE
     */

    public bool gameIsPaused;

    private Canvas canvasPause;
    public Canvas canvasData;

	// Use this for initialization
	void Start () {
        canvasPause = GetComponent<Canvas>();
        canvasPause.enabled = false;
        canvasData.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void PauseResume(){
        gameIsPaused = !gameIsPaused;
        canvasPause.enabled = gameIsPaused;
        canvasData.enabled = !gameIsPaused;
        //controla el tiempo con un operador ternario
        Time.timeScale = (gameIsPaused) ? 0 : 1f;
    }

}