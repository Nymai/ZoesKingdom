using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOptionsMenu : MonoBehaviour {

    /* 
     * SWITCH BETWEEN THE DIFFERENTS OPTIONS TO STAR THE GAME DEPENDING ON PLAYERPREFABS 
     */

    public int game;

	// Use this for initialization
	void Start () {
        game = PlayerPrefs.GetInt("playerGame",0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayResume(){

        if(game == 1){

            FindObjectOfType<LoadSceneOnClick>().LoadByIndex(3);

        }else{

            FindObjectOfType<setPlayerOptions>().resetPlayerGame();

            FindObjectOfType<LoadSceneOnClick>().LoadByIndex(2);

        }
    }

    public void TutorialNewGame(){

        if(game == 0){

            FindObjectOfType<setPlayerOptions>().resetPlayerGame();
            FindObjectOfType<setPlayerOptions>().setPlayerTutorial(1);

            FindObjectOfType<LoadSceneOnClick>().LoadByIndex(2);

        }else{

            FindObjectOfType<setPlayerOptions>().resetPlayerGame();

            FindObjectOfType<MainMenuText>().writeMenu();

        }

    }
}