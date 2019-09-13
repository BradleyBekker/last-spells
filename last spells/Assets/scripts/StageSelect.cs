using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class StageSelect : MonoBehaviour
{
    [SerializeField] int stage;
    private void OnMouseDown()
    {
        switch (stage)
        {
            case 1:
                SceneManager.LoadScene("level1");

                break;

            case 2:
                SceneManager.LoadScene("level2");

                break;

            case 3:
                SceneManager.LoadScene("level3");

                break;

            case 4:
                SceneManager.LoadScene("level4");

                break;



            default:
                break;
        }

    }
}
