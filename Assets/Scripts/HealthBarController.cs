using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class HealthBarController : MonoBehaviour {
    public Image LoadingBar;

    private Transform playerPosition;
    private bool lookAtPlayer;

    // Use this for initialization
    void Start () {
        LoadingBar.fillAmount = 1;
        if(transform.parent.GetComponent<TurtleController>() != null) {
            playerPosition = FindObjectOfType<SteamVR_PlayArea>().transform;
            lookAtPlayer = true;
        }
    }

    private void Update() {
        if(lookAtPlayer)
        transform.LookAt(playerPosition);

    }


    public void DecreaseLife(float amount) {
        LoadingBar.fillAmount -= amount / 100;
    }

}
