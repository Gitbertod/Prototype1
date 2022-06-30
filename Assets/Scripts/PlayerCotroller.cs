using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCotroller : MonoBehaviour
{
    
    public GameObject vehicle;
    public float speed = 5;
    void Start()
    {
        vehicle.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward

        transform.Translate(Vector3.forward * Time.deltaTime *speed);
    }
}
