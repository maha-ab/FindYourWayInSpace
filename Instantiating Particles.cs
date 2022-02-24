using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatingParticles : MonoBehaviour
{

    public GameObject particalPrefab;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          GameObject prefab=Instantiate(particalPrefab, transform.position, transform.rotation);
            Destroy(prefab, 3f);
        }
    }

   
}
