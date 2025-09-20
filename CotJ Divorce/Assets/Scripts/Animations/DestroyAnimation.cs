using UnityEngine;

public class DestroyAnimation : MonoBehaviour
{
    
    public void DestroySelf()
    {

        FindFirstObjectByType<BowlingController>().JaqAnimator.speed = 1;
        FindFirstObjectByType<BowlingController>().JaqAnimator.speed = 1;

        FindFirstObjectByType<BowlingController>().JaqAnimator.transform.position = FindFirstObjectByType<BowlingController>().JaqPos;
        FindFirstObjectByType<BowlingController>().JayAnimator.transform.position = FindFirstObjectByType<BowlingController>().JayPos;

        Destroy(this);

    }

}
