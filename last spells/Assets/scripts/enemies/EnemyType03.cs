using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType03 : BaseEnemyBehaviour
{
    GameObject shotOrigin;
    GameObject shotOrigin1;
    GameObject shotOrigin2;
    private void Start()
    {

        shotOrigin = transform.GetChild(0).gameObject;
        shotOrigin1 = transform.GetChild(1).gameObject;
        shotOrigin2 = transform.GetChild(2).gameObject;
        health = 7;
    }

    public override void MoveBehaviour()
    {

    }

    public override void ShotBehaviour()
    {
        if (CanFire(0.5f))
        {
            Instantiate(bullet, shotOrigin.transform.position, shotOrigin.transform.rotation);
            Instantiate(bullet, shotOrigin1.transform.position, shotOrigin1.transform.rotation);
            Instantiate(bullet, shotOrigin2.transform.position, shotOrigin2.transform.rotation);
        }


    }
    public override void OnDameged()
    {
        health -= 1;
    }
}
