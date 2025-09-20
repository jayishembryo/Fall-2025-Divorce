using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Password : MonoBehaviour
{
    public string CorrectPassword;

    public TextMeshProUGUI PasswordField;

    [SerializeField] GameObject realCredits;

    public void EnterPassword()
    {

        if (PasswordField.text.Contains(CorrectPassword) && (PasswordField.text.Length - 1) == CorrectPassword.Length)
        {

            realCredits.SetActive(true);
            this.gameObject.SetActive(false);

        }

    }
    
    public void QuitPassword()
    {

        PasswordField.text = "";
        this.gameObject.SetActive(false);

    }

}
