using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicBar : MonoBehaviour
{
    Image image;
    PlayerBase player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<WindCharacter>();
        image = GetComponent<Image>();
    }

    private void Update()
    {
        image.fillAmount = player.GetMagicMeter() / 100;
    }
}
