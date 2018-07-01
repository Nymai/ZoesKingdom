using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTutorialPoint : MonoBehaviour {

    /*
     * TRIGGER THE TUTORIAL SCREEN IF TUTORIAL OPTION IS ON THE GAME
     * Each tutorial point must be its own index
     */

    public int tutorialPoint;

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Player"){
            FindObjectOfType<TutorialManager>().SelectTutorialPoint(tutorialPoint);
            Destroy(gameObject);
        }
	}
}