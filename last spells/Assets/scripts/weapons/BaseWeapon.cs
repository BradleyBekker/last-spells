using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    protected GameObject Bullet;
    protected enum Element { Wind, Void, fire };
    protected enum WeaponType {Lance,Sword, Staff }
    protected Element element;
    protected WeaponType type;
    protected float counter;
    protected float dmg;
   public abstract void ShotBehaviour();
    private void Awake()
    {
        Bullet = Resources.Load<GameObject>("prefabs/Pbullet");
    }

    protected bool  CanFire(float fireRate)
    {
        counter = counter + Time.deltaTime;
        if (counter >= fireRate)
        {
            counter = 0;

            return true;
        }
        else
        {
            return false;
        }
    }
}
