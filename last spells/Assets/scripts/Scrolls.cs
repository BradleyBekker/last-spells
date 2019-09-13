using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolls : MonoBehaviour
{
    float scroll = 0;
    Renderer rend;
    float speed = 0.015f;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        scroll += speed * Time.deltaTime;
        rend.material.mainTextureOffset = new Vector2(0,scroll);
    }
}
