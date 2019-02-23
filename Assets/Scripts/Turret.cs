using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    Transform rotator;
    [SerializeField]
    Weapon weapon;
    Transform target;
    
    // Update is called once per frame
    void Update()
    {
        rotator.LookAt(target);

        if (weapon != null && target != null)
            weapon.Attack();
    }

    private void OnTriggerStay(Collider other)
    {
        if (target == null && other.transform.GetComponent<Life>() != null)
            target = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform == target)
            target = null;
    }
}
