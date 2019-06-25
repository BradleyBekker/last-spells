using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    protected BaseWeapon weapon;
    protected float magicMeter;
    protected float speed;
    protected GameObject hitCrystal;
    protected DamageCalculation DC;
    private void Awake()
    {
        hitCrystal = GameObject.Find("hitCrystal");
        if (hitCrystal != null)
        {
            DC = hitCrystal.GetComponent<DamageCalculation>();

            DC.takedamage += DepleteMagicMeter;
        }
    }

    public void Movement() {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }
    
    public void Shoot()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
         weapon.ShotBehaviour();
        }
    }

    protected void DepleteMagicMeter(float amount)
    {
        magicMeter = magicMeter - amount;
        print(magicMeter);
    }
    protected void FillMagicMeter(float amount)
    {
        magicMeter = magicMeter + amount;
    }
}
