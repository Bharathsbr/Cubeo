using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Text : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI t;
    void Update()
    {
        t.text=player.position.z.ToString("0");
        
    }
}
