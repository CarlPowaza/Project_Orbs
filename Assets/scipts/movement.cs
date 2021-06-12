using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{    
    public Rigidbody2D rb;
   



    public float movementSpeed;
    float mx;
    float my;

    // Start is called before the first frame update
    void Start(){
        movementSpeed = 10f;
        

 
    }


    // Update is called once per frame
    void Update()
    {
           mx = Input.GetAxisRaw("Horizontal");
           my = Input.GetAxisRaw("Vertical");
 
    }

        void FixedUpdate(){
     
       
       
                   Vector2 movement = new Vector2(mx * movementSpeed,movementSpeed*my);
                       rb.velocity = movement;



    }

}
