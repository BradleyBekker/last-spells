using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyBehaviour : MonoBehaviour
{
    protected float counter;
    protected float health;
    protected GameObject bullet;
    private void Awake()
    {
        bullet = Resources.Load<GameObject>("prefabs/bullet");
    }
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        ShotBehaviour();
        MoveBehaviour();
    }

    public abstract void MoveBehaviour();
    public abstract void ShotBehaviour();
    public abstract void OnDameged();
    protected bool CanFire(float fireRate)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerShot")
        {
            OnDameged();
            Destroy(collision.gameObject);

        }
    }


}
