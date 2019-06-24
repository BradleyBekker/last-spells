using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : MonoBehaviour
{
    protected float speed = 20;
    void Update()
    {
        MoveForward();
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
    public void MoveForward()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime,Space.Self);
        
    } 
}
