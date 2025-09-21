using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{
    public string CorrectPassword;

    public TextMeshProUGUI PasswordField;

    [SerializeField] GameObject realCredits;

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip evilTheme;

    public void EnterPassword()
    {

        if (PasswordField.text.Contains(CorrectPassword) && (PasswordField.text.Length - 1) == CorrectPassword.Length)
        {

            realCredits.SetActive(true);
            this.gameObject.SetActive(false);

            musicSource.clip = evilTheme;
            musicSource.Play();
            musicSource.volume = 1;

        }
        else if (PasswordField.text != CorrectPassword)
        {

            SceneManager.LoadScene(4);

        }

    }
    
    public void QuitPassword()
    {

        PasswordField.text = "";
        this.gameObject.SetActive(false);

    }

}
