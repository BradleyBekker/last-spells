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
    protected float dmg;
   public abstract void ShotBehaviour();
    
}
