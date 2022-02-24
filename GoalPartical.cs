using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPartical : MonoBehaviour
{

    public GameObject particalPrefab;
    public GameObject spPoint;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject prefab = Instantiate(particalPrefab, spPoint.transform.position, spPoint.transform.rotation);
          //  Destroy(prefab, 3f);
        }
    }

}
