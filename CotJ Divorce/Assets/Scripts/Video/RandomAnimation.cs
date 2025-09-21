using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public List<GameObject> Animations;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(PlayAnimations());
    }

    public IEnumerator PlayAnimations()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10, 20));
            Instantiate(Animations[Random.Range(0, Animations.Count)]);
        }
    }
}
