using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public HealthBarController health;

    public Life playerLife;
    public Life baseLife;

    public GameObject losingText;

    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("Base").GetComponentInChildren<HealthBarController>();
        if (manager == null) {
            manager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(health.LoadingBar.fillAmount <= 0) {
            losingText.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
