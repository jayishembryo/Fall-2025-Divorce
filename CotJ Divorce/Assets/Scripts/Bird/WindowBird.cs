using UnityEngine;

public class WindowBird : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip AC;
    private void OnCollisionEnter(Collision collision)
    {
        AS.PlayOneShot(AC);
        gameObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, -5, 0);
    }
}
