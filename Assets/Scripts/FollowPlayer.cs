using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetCamera = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camer behid
        transform.position = player.transform.position + offsetCamera;
       // transform.rotation = 
    }
}
