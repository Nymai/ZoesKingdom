using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    /*
     * CONTROL ALL SETTING MENU FUNCTIONALITIES
     * Audio: Control the volume
     * Video: Change screen resolution, switching full screen
     */

    public AudioMixer audioMixer;

    public Dropdown resolutionScreenDropdown;

    Resolution[] resolutions;

	private void Start()
	{
        resolutions = Screen.resolutions;

        resolutionScreenDropdown.ClearOptions();

        //create a list with the text of all posible resolutions
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++){
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }

        resolutionScreenDropdown.AddOptions(options);
        resolutionScreenDropdown.value = currentResolutionIndex;
        resolutionScreenDropdown.RefreshShownValue();
	}

	public void SetVolume(float volume){
        audioMixer.SetFloat("masterVolume", volume);
    }

    public void SetResolution(int resolutionIndex){

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }

    public void SetFullScreen(bool isFullScreen){
        Screen.fullScreen = isFullScreen;
    }
}