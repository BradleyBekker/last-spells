using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculation : MonoBehaviour
{
    // Start is called before the first frame update
    public Action<float> takeDamage;

    bool hit = false;

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision);
            if (collision.tag == "EnemyShot")
            {
                hit = true;
                takeDamage(10);
                Destroy(collision.gameObject);
            }
        
    }
    public bool GetHit()
    {
        return hit;
    }
    public void SetHit(bool value)
    {
        hit = value;
    }


}
