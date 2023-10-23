using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAudio : MonoBehaviour
{
    public AudioSource dragonScream;

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            if (!dragonScream.isPlaying)
            {
                dragonScream.Play();
            }
        }
    }
}
