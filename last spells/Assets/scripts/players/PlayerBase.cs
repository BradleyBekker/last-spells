using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    protected bool criticalState = false;
    protected BaseWeapon weapon;
    protected float magicMeter;
    protected float speed;
    protected GameObject hitCrystal;
    protected GameObject dodgeZone;
    protected GameObject gameModeManager;
    protected DamageCalculation DC;
    protected DodgeZone DZ;
    protected Gameover GO;

    

    private void Awake()
    {
        hitCrystal = GameObject.Find("hitCrystal");
        dodgeZone = GameObject.Find("DodgeZone");
        gameModeManager = GameObject.Find("GameModeManager");
        if (hitCrystal != null)
        {
            DC = hitCrystal.GetComponent<DamageCalculation>();
            DZ = dodgeZone.GetComponent<DodgeZone>();
            

            DC.takeDamage += DepleteMagicMeter;
            DZ.healDamage += FillMagicMeter;
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
        if (criticalState)
        {
            GameOver();
        }
        magicMeter = magicMeter - amount;
        if (magicMeter <= 0)
        {
            criticalState = true;
        }
        print(magicMeter);
    }
    protected void FillMagicMeter(float amount)
    {
        magicMeter = magicMeter + amount;
        print(magicMeter);
    }
    public float GetMagicMeter()
    {
        return magicMeter;
    }
   void GameOver()
   {
        GO = gameModeManager.GetComponent<Gameover>();
        
        GO.OnGameOver();
   }

}
