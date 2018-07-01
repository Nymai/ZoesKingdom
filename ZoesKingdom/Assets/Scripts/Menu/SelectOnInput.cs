using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour
{
    /* LET TO USE KEYBOARD TO MOVE ALONG THE GUI WITHOUT THE MOUSE 
     * It's required to have an eventsystem to be able to listen
     * It needs to know whose the first button to start the movements
     */

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false) 
        {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }
    }

    // It's called when the behaviour becomes disabled or inactive 
    private void OnDisable()
    {
        buttonSelected = false;
    }
}