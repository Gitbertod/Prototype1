using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{

    public GameObject propeller;
    void Start()
    {
        
    }

   
    void Update()
    {

        propeller.transform.Rotate(0, 0, 5);


    }
}
