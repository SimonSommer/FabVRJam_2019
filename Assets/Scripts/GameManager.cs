using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;



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
        
    }
}
