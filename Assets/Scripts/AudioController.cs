using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    private AudioSource as;

    private void Awake()
    {
        as = GetComponent<AudioSource>();
    }

    public void FlapSound()
    {

    }
}
