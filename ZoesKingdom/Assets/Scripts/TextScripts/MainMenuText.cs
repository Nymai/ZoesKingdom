using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuText : MonoBehaviour {

    /*
     * WRITE THE MENU TEXT DEPENDING ON THE SELECTED LANGUAGE
     */

    public int game;
    public string lang;

    public Text firstButton;
    public Text secondButton;
    public Text settingsButton;
    public Text quitButton;


    public void writeMenu(){
        //get the button text elements
        firstButton = GameObject.Find("PlayButtonText").GetComponent<Text>();
        secondButton = GameObject.Find("TutorialButtonText").GetComponent<Text>();
        settingsButton = GameObject.Find("SettingsButtonText").GetComponent<Text>();
        quitButton = GameObject.Find("QuitButtonText").GetComponent<Text>();

        lang = PlayerPrefs.GetString("playerLang");
        game = PlayerPrefs.GetInt("playerGame",0);

        selectLanguage();
    }


    private void selectLanguage(){
        switch(lang){
            case "en": englishMenu();
                       break;

            case "es":
                spanishMenu();
                break;

            case "ca":
                catalanMenu();
                break;

            case "gl":
                galicianMenu();
                break;

            case "eu":
                basqueMenu();
                break;

            case "it":
                italianMenu();
                break;

            case "fr":
                frenchMenu();
                break;

            case "nl":
                dutchMenu();
                break;

            case "de":
                germanMenu();
                break;

            default: englishMenu();
                break;
        }
    }


    private void englishMenu(){

        settingsButton.text = "Settings";
        quitButton.text = "Quit Game";

        if(game == 0){
            firstButton.text = "Play";
            secondButton.text = "Tutorial";
        }else{
            firstButton.text = "Resume Game";
            secondButton.text = "New Game";
        }

    }

    private void spanishMenu(){

        settingsButton.text = "Configuración";
        quitButton.text = "Salir del Juego";

        Debug.Log(game);

        if (game == 0)
        {
            firstButton.text = "Jugar";
            secondButton.text = "Tutorial";
        }
        else
        {
            firstButton.text = "Reanudar Juego";
            secondButton.text = "Nuevo Juego";
        }

    }

    private void catalanMenu()
    {

        settingsButton.text = "Configuració";
        quitButton.text = "Sortir del joc";

        if (game == 0)
        {
            firstButton.text = "Jugar";
            secondButton.text = "Tutorial";
        }
        else
        {
            firstButton.text = "Reprendre el Joc";
            secondButton.text = "Nou Joc";
        }

    }

    private void galicianMenu()
    {

        settingsButton.text = "Configuración";
        quitButton.text = "Saír do xogo";

        if (game == 0)
        {
            firstButton.text = "Xogar";
            secondButton.text = "Tutorial";
        }
        else
        {
            firstButton.text = "Resume o xogo";
            secondButton.text = "Novo xogo";
        }

    }

    private void basqueMenu()
    {

        settingsButton.text = "Ezarpenak";
        quitButton.text = "Irten Jokoa";

        if (game == 0)
        {
            firstButton.text = "Play";
            secondButton.text = "Tutoretza";
        }
        else
        {
            firstButton.text = "Berrekin Jokoa";
            secondButton.text = "Joko Berria";
        }

    }

    private void italianMenu()
    {

        settingsButton.text = "Impostazioni";
        quitButton.text = "Abbandonare il Gioco";

        if (game == 0)
        {
            firstButton.text = "Giocare";
            secondButton.text = "Lezione";
        }
        else
        {
            firstButton.text = "Riprendi il gioco";
            secondButton.text = "Nuovo gioco";
        }

    }

    private void frenchMenu()
    {

        settingsButton.text = "Paramètres";
        quitButton.text = "Quitter le Jeu";

        if (game == 0)
        {
            firstButton.text = "Jouer";
            secondButton.text = "Tutoriel";
        }
        else
        {
            firstButton.text = "Reprendre le Jeu";
            secondButton.text = "Nouveau Jeu";
        }

    }

    private void dutchMenu()
    {

        settingsButton.text = "Instellingen";
        quitButton.text = "Sluit Spel";

        if (game == 0)
        {
            firstButton.text = "Spelen";
            secondButton.text = "Tutorial";
        }
        else
        {
            firstButton.text = "Spel Hervatten";
            secondButton.text = "Nieuw Spel";
        }

    }

    private void germanMenu()
    {

        settingsButton.text = "Die Einstellungen";
        quitButton.text = "Spiel Verlassen";

        if (game == 0)
        {
            firstButton.text = "Abspielen";
            secondButton.text = "Tutorial";
        }
        else
        {
            firstButton.text = "Spiel Fortsetzen";
            secondButton.text = "Neues Spiel";
        }

    }

}