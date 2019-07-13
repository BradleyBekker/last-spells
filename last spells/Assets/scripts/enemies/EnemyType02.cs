﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType02 : BaseEnemyBehaviour
{
    GameObject shotOrigin;
    private void Start()
    {
        shotOrigin = transform.GetChild(0).gameObject;
        health = 10;
    }

    public override void MoveBehaviour()
    {

    }

    public override void OnDameged()
    {
        health -= 2;
    }

    public override void ShotBehaviour()
    {
        shotOrigin.transform.Rotate(0, 0, -1);
        if (CanFire(0.2f))
        {
            Instantiate(bullet, shotOrigin.transform.position, shotOrigin.transform.rotation);
        }
    }

}