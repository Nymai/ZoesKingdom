using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour {

    /*
     * MANAGE THE TUTORIAL OPTIONS
     */

    public Canvas tutorialCanvas;
    public Canvas dataCanvas;

    public GameObject tutorialPoints;

    public Text tutorialText;

    public int playerTutorial;

	private void Awake()
	{
        tutorialPoints.SetActive(false);
	}

	// Use this for initialization
	void Start () {

        playerTutorial = PlayerPrefs.GetInt("playerTutorial", 0);

        tutorialText = GameObject.Find("TutorialText").GetComponent<Text>();
        tutorialCanvas.enabled = false;

        if(playerTutorial == 0){
            destroyTutorials();
        }else{
            tutorialPoints.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectTutorialPoint(int tutPoint){

        tutorialCanvas.enabled = true;
        dataCanvas.enabled = false;
        Time.timeScale = 0;

        switch(tutPoint){
            case 1: gameControls();
                break;
            case 2: tutorialText.text = "Tut2";
                break;
            default: PlayTutorial();
                break;
        }
    }

    public void PlayTutorial(){
        tutorialCanvas.enabled = false;
        dataCanvas.enabled = true;
        Time.timeScale = 1f;
    }

    void gameControls(){
        Debug.Log("controles de juego");
        tutorialText.text = "Bienvenid@ al mundo de Zoe \n \n Para moverte por el espacio utiliza las flechas del teclado. \n \n Zoe salta cuando pulsas la barra espaciadora. \n \n Tienes que recoger tantas monedas como puedas, usa las cajas y los barriles para ayudarte a llegar donde no puedas. \n \n Truco: A veces es necesario coger \"carrerilla\" para llegar más lejos o más alto.Si mantienes pulsada la letra Z podrás ir más rápido. \n \n Disfruta el juego";
    }

    public void destroyTutorials(){
        Destroy(tutorialCanvas.gameObject);
        Destroy(tutorialPoints);
        Destroy(gameObject);
    }
}