using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    GameObject fakeCredits;

    private void Start()
    {

        fakeCredits = GetComponentInChildren<Credits>().gameObject;

    }

    void StartGame()
    {

        SceneManager.LoadScene(1);

    }

    void RunFakeCredits()
    {

        fakeCredits.SetActive(true);

    }

    void QuitGame()
    {

        Application.Quit();

    }

}
