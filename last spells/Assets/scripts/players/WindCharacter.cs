using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCharacter : PlayerBase
{
    // Start is called before the first frame update
    void Start()
    {
        weapon = GetComponent<Lance>();
       speed = 5;   
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }
}
