using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleSpawner : MonoBehaviour
{
    public GameObject TurtleModel;

    public float RespawnTime = 3;

    private float time;

    public Transform[] AllTargets;

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= RespawnTime) {
            Instantiate(TurtleModel, transform.position, transform.rotation, transform);
            time = 0;
        }
    }
}
