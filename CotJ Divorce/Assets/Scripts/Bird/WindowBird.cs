using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowBird : MonoBehaviour
{
    public AudioSource AS;
    public AudioSource Glass;
    public AudioClip AC;
    private void OnCollisionEnter(Collision collision)
    {

        if(SceneManager.GetActiveScene().name.Contains("THREE"))
        {

            GameObject.Find("Fight Source").GetComponent<AudioSource>().Pause();

        }

        Debug.Log("bird");
        AS.PlayOneShot(AC);

        if(Glass.clip != null)
        {

            Glass.Play();

        }

        gameObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, -40, 0);

        //THIS SHIT IS SO ASS
        if (SceneManager.GetActiveScene().name.Contains("THREE"))
        {

            FindFirstObjectByType<BowlingController>().PauseAnimators();

        }

    }
}
