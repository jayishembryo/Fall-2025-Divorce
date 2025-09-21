using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public TMP_Text scoreText;

    private void Start()
    {

        float randomScore = Random.Range(-1000000000000000000, 1000000000000000000);
        scoreText.text = randomScore.ToString();

    }

    public void ReturnToMenu()
    {

        SceneManager.LoadScene(0);

    }

}
