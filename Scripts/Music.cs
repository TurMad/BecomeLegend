using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.3f;
        audioSource.clip = audioClips[0];
    }

    public void UpdateAudio(int audioIndex)
    {
        audioSource.clip = audioClips[audioIndex];
        audioSource.Play();
    }
}
