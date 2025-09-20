using UnityEngine;
using UnityEngine.UI;

public class BowlingController : MonoBehaviour
{

    public static int StartingPins = 10;
    public static int PinsHit = 0;

    private BowlingBallBehaviour bbb;
    public GameObject ballClone;
    public GameObject ball;

    public Animator JaqAnimator;
    public Animator JayAnimator;

    public Vector3 JaqPos;
    public Vector3 JayPos;

    [SerializeField] GameObject shockedJaq;
    [SerializeField] GameObject shockedJay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bbb = GameObject.Find("BowlingBallBehaviour").GetComponent<BowlingBallBehaviour>();

        StartingPins = 10;
        PinsHit = 0;

        JaqPos = JaqAnimator.transform.position;
        JayPos = JayAnimator.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        BowlAgain();
    }

    public void BowlAgain()
    {
        /*if (bbb.isballout)
        {
            ballclone = instantiate(ball, transform.position, transform.rotation);
            bbb.isballout = false;
        }*/
    }

    public void PauseAnimators()
    {

        JaqAnimator.speed = 0;
        JayAnimator.speed = 0;

        JaqAnimator.transform.position = new Vector3(10000, 10000, 10000);
        JayAnimator.transform.position = new Vector3(10000, 10000, 10000);

        Instantiate(shockedJaq, JaqPos, Quaternion.identity);
        Instantiate(shockedJay, JayPos, Quaternion.identity);

    }

}
