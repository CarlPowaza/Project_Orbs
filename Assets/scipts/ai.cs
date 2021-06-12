using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
    float lasttime=0f;
    float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
   
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
              
           if(collision.gameObject.tag  =="Player"){
                  Debug.Log("gottem");
                   Destroy(this.gameObject);
                   GameObject manager = GameObject.Find("Gamemanager");
                   healthmanager heal = manager.GetComponent<healthmanager>();
                   heal.healthpoints--;
            } 

    }  

    // Update is called once per frame
    void Update()
    {
            if(lasttime <Time.time ){
                transform.position =new Vector3(transform.position.x+ 1,transform.position.y,transform.position.z);
               lasttime = Time.time + .6f;
            }

    
        
    }
}
