using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    void OnCollisionEnter(Collision o){
        if(o.collider.tag=="Obstacle"){
            movement.enabled=false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
