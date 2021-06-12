using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public Transform player;
    public Transform orb;
    public Camera cam;
    private float canJump = 0f;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Space) && Time.time > canJump){
              Vector3 temp = player.position;
              player.position = orb.position;
              orb.position= temp;
             canJump = Time.time + 1.5f;  
        }
        
    }


}
