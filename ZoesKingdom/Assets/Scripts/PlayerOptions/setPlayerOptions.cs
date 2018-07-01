using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPlayerOptions : MonoBehaviour {

    /*
     * WRITE ALL PARAMETERS IN PLAYERPREFS
     * In this way it's possible to keep little options in the computer and 
     * use them in the next party time
     * Disadvantage: it's just possible keep variables in intenger, float and
     * string form. So for get a boolean is neccesary use intenger in 0 and 1 
     * values
     */

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            PlayerPrefs.DeleteAll();
        }

    }

    public void setPlayerLanguage(string lang)
    {
        PlayerPrefs.SetString("playerLang", lang);
    }

    public void setPlayerGame(int nGame){
        PlayerPrefs.SetInt("playerGame",nGame);
    }

    public void setPlayerTutorial(int nTutorial){
        PlayerPrefs.SetInt("playerTutorial", nTutorial);
    }

    public void setPlayerLevel(int nLevel){
        PlayerPrefs.SetInt("playerLevel", nLevel);
    }

    public void setPlayerCoins(int nCoins){
        PlayerPrefs.SetInt("playerCoins", nCoins);
    }

    public void setPlayerKeys(int nKeys){
        PlayerPrefs.SetInt("playerKeys", nKeys);
    }

    public void setPlayerScore(int nScore){
        PlayerPrefs.SetInt("playerScore", nScore);
    }

    public void resetPlayerGame(){
        setPlayerGame(0);
        setPlayerTutorial(0);
        setPlayerLevel(0);
        setPlayerCoins(0);
        setPlayerKeys(0);
    }

}