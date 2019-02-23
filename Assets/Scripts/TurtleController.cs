using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TurtleController : MonoBehaviour
{




    // Path finding
    public Transform[] goals;
    private NavMeshAgent agent;

    public int indexGoals = 0;

    private bool CrashedPlayer;
    private float t;

    private void Start() {
        goals = transform.parent.GetComponent<TurtleSpawner>().AllTargets;

        //goal = FindObjectOfType<BaseController>().transform;
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = true;
        agent.destination = goals[indexGoals].position;

    }

    private void Update() {
        
        if (Vector3.Distance(goals[indexGoals].position, transform.position) < 1.0f) {
            if(indexGoals < goals.Length - 1) {
                indexGoals++;
                agent.destination = goals[indexGoals].position;
            } else {
                Destroy(gameObject);
            }
            
        }




    }











    // Tracks, if angel have attacked player to stop him for some seconds
    private void OnTriggerEnter(Collider other) {
        // If the angel crashes the player without being seen
        if (other.gameObject.CompareTag("Player")) {

            CrashedPlayer = true;
            agent.enabled = false;
           
        }
    }


}
