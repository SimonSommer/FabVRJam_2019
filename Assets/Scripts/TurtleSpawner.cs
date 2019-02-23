using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleSpawner : MonoBehaviour
{
    public GameObject TurtleModel;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(TurtleModel, transform.position, transform.rotation);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
