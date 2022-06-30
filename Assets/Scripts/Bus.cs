using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    Vector3 direction;
    float speed = 0;
    void Start()
    {
        speed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.forward * speed * Time.deltaTime;
        transform.Translate(direction);
    }
}
