using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    void Start()
    {
        source.PlayOneShot(clip);
    }
}
