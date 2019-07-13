using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeZone : MonoBehaviour
{
    public Action<float> healDamage;
    [SerializeField] DamageCalculation DC;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DC.SetHit(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag== "EnemyShot" && !DC.GetHit() )
        {
            healDamage(10);
        }
    }

}
