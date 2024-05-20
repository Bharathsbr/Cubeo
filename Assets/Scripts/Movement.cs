using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ff=1000f;
    public float xf=500f;
    void FixedUpdate()
    {
        rb.AddForce(0,0,ff*Time.deltaTime);   
    }

    void Update(){
         
        if(Input.GetKey("a")){
            rb.AddForce(-xf * Time.deltaTime,0,0,ForceMode.VelocityChange);
           
        }
        if(Input.GetKey("d")){
            rb.AddForce(xf * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y<0.2){
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
