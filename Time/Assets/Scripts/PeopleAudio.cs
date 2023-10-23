using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleAudio : MonoBehaviour
{

    public AudioSource scream;

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            if (!scream.isPlaying)
            {
                scream.Play();
            }
        }
    }
}
