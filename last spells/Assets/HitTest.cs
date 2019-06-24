using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTest : MonoBehaviour
{
    float fire_start_time;

    private void Start()
    {
        Instantiate(GameObject.Find("bullet"));


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    }

    void fire()
    {
        
   
    }
}
