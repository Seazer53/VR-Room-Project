using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBallSound : MonoBehaviour
{
    private AudioSource _audio;
    private Rigidbody _rb;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audio.PlayOneShot(_audio.clip, _rb.velocity.magnitude);
    }
}
