using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    Transform rotator;
    [SerializeField]
    Weapon weapon;
    public Transform target;

    public float offset;
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.position;
        targetPos.y += offset;
        rotator.LookAt(targetPos);

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
