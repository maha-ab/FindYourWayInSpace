using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float health;
    public static float enemiHealth;

    public Image mater;
    public Image mater2;

    public static bool heltheBarFlashRed;

    public Animator anim;

 
    // Start is called before the first frame update
    void Start()
    {
        health = 1;
        enemiHealth = 1;
        heltheBarFlashRed = false;
       
       
    }

    // Update is called once per frame
    void Update()
    {
        mater.fillAmount = health;
        mater2.fillAmount = enemiHealth;

        if (heltheBarFlashRed)
        {
            anim.SetTrigger("FlashRed");
            heltheBarFlashRed = false;
        }
    }

}
