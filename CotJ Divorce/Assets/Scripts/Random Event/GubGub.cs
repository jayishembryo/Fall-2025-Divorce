using System.Collections;
using UnityEngine;

public class GubGub : MonoBehaviour
{
    public GameObject GubGubImage;
    public float SecondsToWaitSmall;
    public float SecondsToWaitBig;
    public bool BowlingOccurred;
    private Coroutine SpawningCoroutine;
    public float speed = 5;
    public AudioClip GubGubVoiceLine;
    private AudioSource AS;

    private void Start()
    {
        AS = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (BowlingOccurred)
        {
            if (SpawningCoroutine == null)
            {
                SpawningCoroutine = StartCoroutine(SpawnSprites());
            }
        }
    }

    public IEnumerator SpawnSprites()
    {
        while (BowlingOccurred)
        {
            yield return new WaitForSeconds(Random.Range(SecondsToWaitSmall, SecondsToWaitBig));
            GameObject instantiatedObject = Instantiate(GubGubImage, transform.position, Quaternion.identity);
            instantiatedObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(-speed, 0, 0);

            yield return new WaitForSeconds(.1f);
            AS.PlayOneShot(GubGubVoiceLine);

        }
    }
}
