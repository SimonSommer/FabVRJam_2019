using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public Life playerLife;
    public Life baseLife;

    public GameObject losingText;

    // Start is called before the first frame update
    void Start()
    {
        if(manager == null) {
            manager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLife.health <= 0 || baseLife.health <= 0) {
            losingText.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
