using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculation : MonoBehaviour
{
    // Start is called before the first frame update
    public Action<float> takedamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        takedamage(10);
    }
}
