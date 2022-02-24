using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    public GameObject LaserGun1;
    public GameObject LaserGun2;

    private bool isActive=true;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            StartCoroutine(DeActivate());
        }
        else
        StartCoroutine(Activate());
    }

    IEnumerator Activate()
    {
       
        yield return new WaitForSeconds(3f);

        LaserGun1.SetActive(true);
        LaserGun2.SetActive(true);
        isActive = true;
    }

    IEnumerator DeActivate()
    {
        yield return new WaitForSeconds(3f);
        LaserGun1.SetActive(false);
        LaserGun2.SetActive(false);
        isActive = false;
    }

    
}
