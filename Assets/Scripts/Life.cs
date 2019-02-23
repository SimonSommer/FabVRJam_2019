using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    UnityEvent died = new UnityEvent();


    public float health = 100f;

    public void Damage(float amount)
    {
        health -= amount;

        if (health < 0)
        {
            Destroy(gameObject);
            died.Invoke();
        }
    }
}
