using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform newSpawnLocation;

    Respawn respawnSecript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            respawnSecript = other.GetComponent<Respawn>();
            respawnSecript.spawnPoint.position = newSpawnLocation.position;
        }
    }
}
