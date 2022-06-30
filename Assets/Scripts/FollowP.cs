
using UnityEngine;

public class FollowP : MonoBehaviour
{

    public GameObject Vehicle;
    private Vector3 offset,offset2;
    public GameObject cam;
    public KeyCode keyCode;
    public bool engine = false;
   
    void Start()
    {
        
        offset = new Vector3(0,5,-8);
        offset2 = new Vector3(0, 1.73f, 1.40f);

    }

    
    void LateUpdate()
    {
        transform.position = Vehicle.transform.position + offset;
    }
    


}
