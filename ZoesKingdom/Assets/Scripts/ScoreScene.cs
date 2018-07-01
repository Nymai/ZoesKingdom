using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScene : MonoBehaviour {

    /*
     * MANAGE THE SCORE SCENE
     * Calculate the player score, compare it with the best, print the records
     * on the screen and update the affected player prefs
     * As well control the activation of UI after a few seconds
     */

    public int secondsToWait;
    public GameObject menu;

    public int currentScore;
    public Text currentScoreText;
    public int bestScore;
    public Text bestScoreText;
    public Text mainTitleText;



	// Use this for initialization
	void Start () {
        StartCoroutine(ChangeScene());

        currentScore = PlayerPrefs.GetInt("playerCoins") + (11 * PlayerPrefs.GetInt("playerKeys"));
        bestScore = PlayerPrefs.GetInt("playerScore", 0);

        WriteScore();

        FindObjectOfType<setPlayerOptions>().setPlayerGame(0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(secondsToWait);
        menu.SetActive(true);

    }

    void WriteScore(){

        currentScoreText.text = "You: " + currentScore;

        if(currentScore >= bestScore){
            mainTitleText.text = "Zoe's Kingdom \n You got it!!! \n You're the best";
            FindObjectOfType<setPlayerOptions>().setPlayerScore(currentScore);
            bestScoreText.text = "Best: " + currentScore;
        }else{
            bestScoreText.text = "Best: " + bestScore;
        }
    }
}