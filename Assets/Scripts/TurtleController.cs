using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TurtleController : MonoBehaviour
{




    // Path finding
    public Transform goal;
    private NavMeshAgent agent;

    public bool AngelFound;

    private bool CrashedPlayer;
    private float t;

    private void Start() {
        goal = FindObjectOfType<BaseController>().transform;
        agent = GetComponent<NavMeshAgent>();

        agent.enabled = true;
        

    }

    private void Update() {
        agent.destination = goal.position;


    }











    // Tracks, if angel have attacked player to stop him for some seconds
    private void OnTriggerEnter(Collider other) {
        // If the angel crashes the player without being seen
        if (other.gameObject.CompareTag("Player") && !AngelFound) {

            CrashedPlayer = true;
            agent.enabled = false;
            AngelFound = true;
        }
    }


}
