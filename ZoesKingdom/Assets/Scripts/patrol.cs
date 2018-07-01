using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour {

    /*
     * CONTROL PATROL ENEMIES MOVEMENT AND THEIR INTERACTION WITH MAIN CHARACTER
     */

    public Transform target;
    public Transform respawnPoint;
    public GameObject agentPoint;
    public int secondsToWait;

    NavMeshAgent agent;
    bool onPersecution = false;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(StartPersecution());
	}
	
	// Update is called once per frame
	void Update () {

        if(onPersecution){
            agent.destination = target.position;
        }

        if(target.transform.position == respawnPoint.transform.position){
            agent.transform.position = agentPoint.transform.position;
            onPersecution = false;
            StartCoroutine(StartPersecution());
        }

	}

    private void OnTriggerEnter(Collider other){
        
        if (other.tag == "Player"){
            
            FindObjectOfType<GameManager>().AddGold(-5);

            target.transform.position = respawnPoint.transform.position;
            agent.transform.position = agentPoint.transform.position;
        }

        if(other.tag == "EnemyKiller"){
            
            FindObjectOfType<GameManager>().AddGold(20);

            Destroy(gameObject);
            Destroy(agentPoint);
        }
    }

    IEnumerator StartPersecution()
    {
        yield return new WaitForSeconds(secondsToWait);
        onPersecution = true;

    }

}