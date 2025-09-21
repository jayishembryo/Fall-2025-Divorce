using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{

    int timer = 0;

    private void Start()
    {

        StartCoroutine(PlayCutscene());

    }

    IEnumerator PlayCutscene()
    {

        while(timer < 18)
        {

            timer += 1;
            yield return new WaitForSeconds(1);
            Debug.Log(timer);

        }

        SceneManager.LoadScene(0);

    }

}
