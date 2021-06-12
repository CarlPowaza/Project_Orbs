using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthmanager : MonoBehaviour
{
    public int healthpoints = 3;
    public Camera cam;
    public CircleCollider2D player;
    public CircleCollider2D orb;


    void Update()
    {
        if(healthpoints ==0)  Application.LoadLevel(Application.loadedLevel);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {  
          Destroy(other.gameObject);
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "enemy")
        {
            
            Debug.Log("Triggered by Enemy");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

      /*    Debug.Log("got");
           if(collision.tag =="enemy"){
                 Destroy(collsion); 
            } */

    }   
}
