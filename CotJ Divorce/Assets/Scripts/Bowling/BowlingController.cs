using UnityEngine;
using UnityEngine.UI;

public class BowlingController : MonoBehaviour
{

    public static int StartingPins = 10;
    public static int PinsHit = 0;

    private BowlingBallBehaviour bbb;
    public GameObject ballClone;
    public GameObject ball;
    public GameObject pin;

    public Animator JaqAnimator;
    public Animator JayAnimator;

    public Vector3 JaqPos;
    public Vector3 JayPos;

    [SerializeField] GameObject shockedJaq;
    [SerializeField] GameObject shockedJay;

    public bool IsTurn2;
    public bool IsStartOfFrame;

    public float BallXValue = 0f;
    public float BallYValue = 0f;
    public float BallZValue = 0f;

    public float Pin1XValue = 0f;
    public float Pin1YValue = 0f;
    public float Pin1ZValue = 0f;

    public float Pin2XValue = 0f;
    public float Pin2YValue = 0f;
    public float Pin2ZValue = 0f;

    public float Pin3XValue = 0f;
    public float Pin3YValue = 0f;
    public float Pin3ZValue = 0f;

    public float Pin4XValue = 0f;
    public float Pin4YValue = 0f;
    public float Pin4ZValue = 0f;

    public float Pin5XValue = 0f;
    public float Pin5YValue = 0f;
    public float Pin5ZValue = 0f;

    public float Pin6XValue = 0f;
    public float Pin6YValue = 0f;
    public float Pin6ZValue = 0f;

    public float Pin7XValue = 0f;
    public float Pin7YValue = 0f;
    public float Pin7ZValue = 0f;

    public float Pin8XValue = 0f;
    public float Pin8YValue = 0f;
    public float Pin8ZValue = 0f;

    public float Pin9XValue = 0f;
    public float Pin9YValue = 0f;
    public float Pin9ZValue = 0f;

    public float Pin10XValue = 0f;
    public float Pin10YValue = 0f;
    public float Pin10ZValue = 0f;

    public GameObject Pin1Location;
    public GameObject Pin2Location;
    public GameObject Pin3Location;
    public GameObject Pin4Location;
    public GameObject Pin5Location;
    public GameObject Pin6Location;
    public GameObject Pin7Location;
    public GameObject Pin8Location;
    public GameObject Pin9Location;
    public GameObject Pin10Location;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bbb = GameObject.Find("BowlingBallBehaviour").GetComponent<BowlingBallBehaviour>();

        StartingPins = 10;
        PinsHit = 0;
        IsStartOfFrame = true;

        //JaqPos = JaqAnimator.transform.position;
        //JayPos = JayAnimator.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       if (IsStartOfFrame)
        {
            StartOfFrame();
        }

        //&& bbb.IsBallOut
        if (IsTurn2)
        {
            IsStartOfFrame = true;
        }
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

        //JaqAnimator.speed = 0;
        //JayAnimator.speed = 0;

        //JaqAnimator.transform.position = new Vector3(10000, 10000, 10000);
        //JayAnimator.transform.position = new Vector3(10000, 10000, 10000);

        //Instantiate(shockedJaq, JaqPos, Quaternion.identity);
        //Instantiate(shockedJay, JayPos, Quaternion.identity);

    }

    public void StartOfFrame()
    {
        Instantiate(ball, new Vector3(BallXValue, BallYValue, BallZValue), Quaternion.identity);
        
        IsTurn2 = false;

        Instantiate(pin, Pin1Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin2Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin3Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin4Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin5Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin6Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin7Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin8Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin9Location.transform.position, Quaternion.identity);
        Instantiate(pin, Pin10Location.transform.position, Quaternion.identity);

        IsStartOfFrame = false;
    }


}
