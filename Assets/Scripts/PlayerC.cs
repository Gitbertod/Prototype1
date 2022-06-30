using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{

    private float speed = 30;
    private float turnSpeed = 30;
    private float horizontalInput;
    private float horizontalInput2;
    private float verticalInput;
    private float verticalInput2;
    

    [SerializeField] private GameObject player;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;


    private void Awake()
    {
        
        
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       //Player 1
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 
        
        //Player 2
        horizontalInput2 = Input.GetAxis("Horizontal2");
        verticalInput2 = Input.GetAxis("Vertical2");
      

        if (player == GameObject.Find("Vehicle")) 
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            player.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        }
        if(player == GameObject.Find("Vehicle2")) 
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput2);
            player.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput2);
        }

        if (Input.GetKeyDown(switchKey)) 
        { 
            mainCamera.enabled = !mainCamera.enabled; 
            hoodCamera.enabled = !hoodCamera.enabled; 
        }

    }
}
