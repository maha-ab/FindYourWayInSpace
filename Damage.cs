using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.health -= 0.1f;

            if (GameManager.health >= 0)
            {
                GameManager.heltheBarFlashRed = true;

            }
        }
        
    }

}
