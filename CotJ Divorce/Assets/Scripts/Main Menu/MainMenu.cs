using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] GameObject fakeCredits;

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

}
