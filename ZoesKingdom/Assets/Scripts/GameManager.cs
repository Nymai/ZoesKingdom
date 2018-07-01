using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    /*
     * MANAGE THE GAME ISSUES
     * Refresh the coin and key counters on the screen
     * Save the records in Prefs
     * Controls the initial character position 
     */

    public int currentCoins;
    public Text coinsText;
    public int currentKeys;
    public Text keysText;

    public Transform player;

    public Transform levelPoint1;
    public Transform levelPoint2;
    public Transform levelPoint3;
    public Transform levelPoint4;

    int level;
    int game;

	// Use this for initialization
	void Start () {

        game = PlayerPrefs.GetInt("playerGame", 0);
        level = PlayerPrefs.GetInt("playerLevel", 0);
        currentCoins = PlayerPrefs.GetInt("playerCoins", 0);
        currentKeys = PlayerPrefs.GetInt("playerKeys", 0);


        if(game == 1){
            switch (level)
            {
                case 1:
                    player.transform.position = levelPoint2.transform.position;
                    break;
                case 2:
                    player.transform.position = levelPoint3.transform.position;
                    break;
                case 3:
                    player.transform.position = levelPoint4.transform.position;
                    break;
                default:
                    player.transform.position = levelPoint1.transform.position;
                    break;
            }

            coinsText.text = "" + currentCoins;
            keysText.text = "" + currentKeys;
        }


	}

    public void AddGold(int valueCoin){
        currentCoins += valueCoin;
        coinsText.text = "" + currentCoins;
    }

    public void AddKey(){
        currentKeys++;
        keysText.text = "" + currentKeys;
    }


    public void saveCollection(){
        FindObjectOfType<setPlayerOptions>().setPlayerCoins(currentCoins);
        FindObjectOfType<setPlayerOptions>().setPlayerKeys(currentKeys);
    }

	private void OnApplicationQuit()
	{
        saveCollection();
	}

}