using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform startTransform;

    public float cooldown = 0.5f;

    public float _timer = 0;

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer < 0)
            _timer = 0;
    }
    
    public void Attack()
    {
        if(_timer == 0)
        {
            Debug.Log("shpoot");

            GameObject go =  Instantiate(bulletPrefab, startTransform.position, startTransform.rotation);

            _timer = cooldown;
        }
    }
}
