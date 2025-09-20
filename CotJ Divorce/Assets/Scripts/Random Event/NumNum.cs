using System.Collections;
using UnityEngine;

public class NumNum : MonoBehaviour
{
    public GameObject NumNumImage;
    public float SecondsToWaitSmall;
    public float SecondsToWaitBig;
    public bool BowlingOccurred;
    private Coroutine SpawningCoroutine;
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
            yield return new WaitForSeconds(Random.Range(SecondsToWaitSmall, SecondsToWaitBig));
            GameObject instantiatedObject = Instantiate(NumNumImage, transform.position, Quaternion.identity);
            instantiatedObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(speed, 0, 0);

        }
    }
}
