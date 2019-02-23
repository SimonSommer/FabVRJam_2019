using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform startTransform;

    public float cooldown = 0.5f;

    private float _timer = 0;

    // Update is called once per frame
    void Update()
    {
        _timer = Mathf.Clamp(_timer - Time.deltaTime, 0, cooldown);
    }
    
    public void Attack()
    {
        if(_timer <= 0)
        {
            Instantiate(bulletPrefab, startTransform.position, startTransform.rotation);

            _timer = cooldown;
        }
    }
}
