using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void Quit(){
        Debug.Log("end");
        Application.Quit();
    }
}
