using UnityEngine;

public class BowlingController : MonoBehaviour
{

    public static int StartingPins = 10;
    public static int PinsHit = 0;

    private BowlingBallBehaviour bbb;
    public GameObject ballClone;
    public GameObject ball;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bbb = GameObject.Find("BowlingBallBehaviour").GetComponent<BowlingBallBehaviour>();

        StartingPins = 10;
        PinsHit = 0;

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
}
