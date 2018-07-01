using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyOn : MonoBehaviour {

    /*
     * CHECK IF ALL PATROL ENEMIES ARE DEAD AND SHOW THE KEY
     */

    public GameObject enemies;
    public GameObject keyEnabled;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if(keyEnabled != null){
            if (enemies.transform.childCount == 0)
            {
                keyEnabled.SetActive(true);
            }
        }
	}
}