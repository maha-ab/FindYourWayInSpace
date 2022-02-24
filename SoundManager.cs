using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip glassSmatchClip;
    public AudioClip shootClip;
    public AudioClip explosion;

    public AudioSource audioSource;


    public void GlassSmatch()
    {
        audioSource.PlayOneShot(glassSmatchClip);
    }

    public void Shoot()
    {
        audioSource.PlayOneShot(shootClip);
    }

    public void Explosion()
    {
        audioSource.PlayOneShot(explosion);
    }
}
