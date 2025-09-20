using UnityEngine;

public class Credits : MonoBehaviour
{

    //shitty ass variable name
    [SerializeField] GameObject realCreditsSequenceStart;

    public void RunRealCredits()
    {

        realCreditsSequenceStart.SetActive(true);

    }

    public void ExitCredits()
    {

        this.gameObject.SetActive(false);

    }

}
