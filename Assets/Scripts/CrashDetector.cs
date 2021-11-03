using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : LevelManager
{
    [SerializeField]
    ParticleSystem collisionEffect;
    [SerializeField] AudioClip crashSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            collisionEffect.Play();
            Invoke("RestartScene", restartDelay);
        }
    }

}

