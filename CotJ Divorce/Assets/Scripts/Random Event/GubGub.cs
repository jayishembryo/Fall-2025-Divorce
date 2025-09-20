using System.Collections;
using UnityEngine;

public class GubGub : MonoBehaviour
{
    public GameObject GubGubImage;
    public float SecondsToWait;
    public bool BowlingOccurred;
    private Coroutine SpawningCoroutine;
    private Rigidbody rb;
    public float speed = 5;

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
            yield return new WaitForSeconds(SecondsToWait);
            GameObject instantiatedObject = Instantiate(GubGubImage, transform.position, Quaternion.identity);
            instantiatedObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(-speed, 0, 0);

        }
    }
}
