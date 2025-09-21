using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] GameObject fakeCredits;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip quitClip;
    [SerializeField] List<AudioClip> playTheGameSounds = new List<AudioClip>();

    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }

    public void RunFakeCredits()
    {

        fakeCredits.SetActive(true);

    }

    public void QuitGame()
    {

        Application.Quit();

    }

    public void OnPlayButtonHover()
    {

        int randomClip = Random.Range(0, playTheGameSounds.Count);
        audioSource.clip = playTheGameSounds[randomClip];
        audioSource.Play();

    }

    public void OnQuitButtonHover()
    {

        audioSource.clip = quitClip;
        audioSource.Play();

    }

}
