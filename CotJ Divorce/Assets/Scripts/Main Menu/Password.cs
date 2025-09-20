using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Password : MonoBehaviour
{

    string playerPassword;
    public string CorrectPassword;
    bool isPasswordCorrect;

    public TextMeshProUGUI PasswordField;

    [SerializeField] GameObject realCredits;

    void Update()
    {

        playerPassword = PasswordField.text;

        if (playerPassword.Contains(CorrectPassword) && (playerPassword.Length - 1) == CorrectPassword.Length)
        {

            isPasswordCorrect = true;

        }
        else { isPasswordCorrect = false; }

    }

    public void EnterPassword()
    {

        if (!isPasswordCorrect)
        {

            return;

        }

        realCredits.SetActive(true);
        this.gameObject.SetActive(false);

    }
    
    public void QuitPassword()
    {

        PasswordField.text = "";
        this.gameObject.SetActive(false);

    }

}
