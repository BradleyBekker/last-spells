using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType04 : BaseEnemyBehaviour
{
    // Start is called before the first frame update
    GameObject shotOrigin;
    GameObject boss;

    List<GameObject> shotOrigins = new List<GameObject>();
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            shotOrigins.Add(transform.GetChild(i).gameObject);
        }

        health = 235;
    }

    public override void MoveBehaviour()
    {
   
        


    }

    public override void OnDameged()
    {
        health -= 1;
    }

    public override void ShotBehaviour()
    {
        if (CanFire(0.5f))
            for (int i = 0; i < shotOrigins.Count; i++)
            {

                Instantiate(bullet, shotOrigins[i].transform.position, shotOrigins[i].transform.rotation);
                
            }
    }
}
