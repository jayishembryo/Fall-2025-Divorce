using System.Runtime.CompilerServices;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class BirdController : MonoBehaviour
{

    PlayerInput birdInput;
    InputAction hitWindow;

    [SerializeField] List<AudioClip> birdSounds = new List<AudioClip>();

    [SerializeField] AudioSource glassSource;
    [SerializeField] AudioSource playerSource;

    public void Start()
    {

        birdInput = GetComponent<PlayerInput>();
        hitWindow = birdInput.currentActionMap.FindAction("HitWindow");

        hitWindow.started += HitWindow_started;

    }

    private void HitWindow_started(InputAction.CallbackContext context)
    {

        glassSource.Play();

        int randomClip = Random.Range(0, birdSounds.Count);
        playerSource.clip = birdSounds[randomClip];
        playerSource.Play();

    }

}
