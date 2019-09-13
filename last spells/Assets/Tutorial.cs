using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    GameObject help;
    // Start is called before the first frame update
    void Start()
    {
        help = GameObject.Find("tutorial");
        help.SetActive(false);
    }

    // Update is called once per frame



    private void OnMouseDown()
    {        
        if (!help.active)
        {
            help.SetActive(true);

        }
        else if(help.active)
        {
            help.SetActive(false);
        }
    }
}
