using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScript : MonoBehaviour
{
   public bool stage1cleared = false;
   public bool stage2cleared = false;
   public bool stage3cleared = false;
   public bool stage4cleared = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

    }
   public void StageCleared(int stage)
    {
        switch (stage)
        {
            default:
                break;

            case 1:
                stage1cleared = true;
                break;
            case 2:
                stage2cleared = true;
                break;
            case 3:
                stage3cleared = true;
                break;
            case 4:
                stage4cleared = true;
                break;


        }
    }
}
