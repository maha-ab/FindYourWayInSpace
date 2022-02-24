using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalsystemDamage : MonoBehaviour
{

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("hit");

        if (other.gameObject.tag == ("Player"))
        {
            GameManager.health -= 0.01f;
            Debug.Log("damage  " + GameManager.health);

            if (GameManager.health >= 0)

            {
                GameManager.heltheBarFlashRed = true;

            }
        }

    }

    

}
  

    

