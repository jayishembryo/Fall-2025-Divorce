using UnityEngine;

public class Kill : MonoBehaviour
{
    public float TimeTilDeath;
    // Update is called once per frame
    void Update()
    {
        TimeTilDeath -= Time.deltaTime;

        if (TimeTilDeath <= 0)
        {
            Destroy(gameObject);
        }
    }
}
