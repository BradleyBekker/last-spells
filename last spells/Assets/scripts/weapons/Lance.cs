using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lance : BaseWeapon
{

    // Start is called before the first frame update
    private void Start()
    {
        Bullet = Resources.Load<GameObject>("prefabs/Pbullet");
        element = Element.Wind;
        type = WeaponType.Lance;
        dmg = 10;
    }
    public override void ShotBehaviour()
    {
        Vector2 pos = new Vector2(transform.position.x,transform.position.y+1);
        Instantiate(Bullet,pos,Quaternion.identity);
    }
}
