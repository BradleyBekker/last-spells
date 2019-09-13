using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_01 : BaseEnemyBehaviour
{
    bool movedirection = true;
    GameObject shotOrigin;
    GameObject shotOrigin1;
    GameObject shotOrigin2;
    // Start is called before the first frame update
    void Start()
    {
        shotOrigin = transform.GetChild(0).gameObject;
        shotOrigin1 = transform.GetChild(1).gameObject;
        shotOrigin2 = transform.GetChild(2).gameObject;

        health = 20;
    }


  
    public override void MoveBehaviour()
    {

        if (transform.position.x > 8)
        {
            movedirection = false;
        }
        else if (transform.position.x < -8)
        {
            movedirection = true;
        }

        if (movedirection)
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }
    }
    public override void ShotBehaviour()
    {
        if (CanFire(1)) {
            Instantiate(bullet, shotOrigin.transform.position, shotOrigin.transform.rotation);
            Instantiate(bullet, shotOrigin1.transform.position, shotOrigin1.transform.rotation);
            Instantiate(bullet, shotOrigin2.transform.position, shotOrigin2.transform.rotation);
        }
        if (CanFire(2))
        {
            Instantiate(bullet, shotOrigin.transform.position, shotOrigin.transform.rotation);
            Instantiate(bullet, shotOrigin1.transform.position, shotOrigin1.transform.rotation);
            Instantiate(bullet, shotOrigin2.transform.position, shotOrigin2.transform.rotation);

        }
    }
    public override void OnDameged()
    {
        health--;
    }
}
