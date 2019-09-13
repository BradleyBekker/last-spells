using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_02 : BaseEnemyBehaviour
{

    List<GameObject> shotOrigins = new List<GameObject>();
    Vector2 speed = new Vector2(1, 2);

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < transform.childCount; i++)
        {
            shotOrigins.Add(transform.GetChild(i).gameObject);
        }

        health = 30;
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
    public override void ShotBehaviour()
    {
        if (CanFire(1f))
            for (int i = 0; i < shotOrigins.Count; i++)
        {
            
            Instantiate(bullet, shotOrigins[i].transform.position, shotOrigins[i].transform.rotation);
        }
    }
    public override void OnDameged()
    {
        health--;
    }
}
