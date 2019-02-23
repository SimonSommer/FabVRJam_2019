using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 1;
    public float damage = 10;

    // Update is called once per frame
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Life life = other.gameObject.GetComponent<Life>();

        if (life != null)
        {
            life.Damage(damage);
        }

        Destroy(gameObject);
    }
}
