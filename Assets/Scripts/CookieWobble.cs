using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieWobble : MonoBehaviour
{
    public Light light;
    float startsize;
    float x;
    public float value = 50;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        startsize = light.cookieSize;
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * speed;

        light.cookieSize = startsize + Mathf.Sin(x) * value;
    }
}
