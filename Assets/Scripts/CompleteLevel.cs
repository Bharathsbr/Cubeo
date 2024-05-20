using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter(){
        gm.CompleteLevel();
    }
}
