using UnityEngine;

public class ReturnAnimations : MonoBehaviour
{
    
    public void ActivateUnshockedTrigger()
    {

        FindFirstObjectByType<BowlingController>().JaqAnimator.SetTrigger("Unshocked");
        FindFirstObjectByType<BowlingController>().JayAnimator.SetTrigger("Unshocked");

        GameObject.Find("Fight Source").GetComponent<AudioSource>().UnPause();

    }

}
