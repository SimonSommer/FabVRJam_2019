using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
