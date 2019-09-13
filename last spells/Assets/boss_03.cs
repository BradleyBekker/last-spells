using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_03 : BaseEnemyBehaviour
{
    Vector2 speed = new Vector2(1, 2);

    List<GameObject> shotOrigins = new List<GameObject>();
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            shotOrigins.Add(transform.GetChild(i).gameObject);
        }

        health = 35;
    }


    public override void ShotBehaviour()
    {
        if (CanFire(0.5f))
            for (int i = 0; i < shotOrigins.Count; i++)
            {

                Instantiate(bullet, shotOrigins[i].transform.position, shotOrigins[i].transform.rotation);
            }
    }


    public override void MoveBehaviour()
    {
        if (transform.position.x > 8 || transform.position.x < -8)
        {
            speed.x = speed.x * -1;
        }
        else if (transform.position.y > 2.13f || transform.position.y < -1)
        {
            speed.y = speed.y * -1f;
        }




        transform.Translate(speed * Time.deltaTime);


    }

    public override void OnDameged()
    {
        speed = new Vector2(Random.Range(0.1f, 3), Random.Range(0.1f, 3));
        health--;
    }
}
