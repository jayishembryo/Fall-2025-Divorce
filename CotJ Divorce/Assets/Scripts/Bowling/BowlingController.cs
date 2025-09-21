using UnityEngine;
using UnityEngine.UI;

public class BowlingController : MonoBehaviour
{

    public static int StartingPins = 10;
    public static int PinsHit = 0;
    public Vector3 BallStartRotation; 

    private BowlingBallBehaviour bbb;
    //public GameObject ballClone;
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
    public bool IsEndOfFrame;
    public bool NeedNewBall;

   

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

    public GameObject BallLocation;


    public int AmountOfTimesBowled = 0;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Instantiate is spawnign in a game object, ball is the game object, BallLocation is where it's spawning, and transform.position is giving it the x,y,z of where it should be from the location
        // Quaternion is the rotation of the object, Euler sets a spepcific predetermined rotation, it needs a vector 3 to tell it where to go, since you don't have one you need to make on, that is the value of the rotation you want to set
       Instantiate(ball, BallLocation.transform.position, Quaternion.Euler (BallStartRotation));

        //bbb is setting the varible, FindFirstObjectByType is looking for an object with bowling ball behaviour on it in the scene, in <> is what it's looking for
       bbb = FindFirstObjectByType<BowlingBallBehaviour>();
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

        if (NeedNewBall)
        {
            Instantiate(ball, BallLocation.transform.position, Quaternion.Euler(BallStartRotation));
            NeedNewBall = false;
            if (IsTurn2)
            {
                IsTurn2 = false;
                IsStartOfFrame = true;
                AmountOfTimesBowled += 1;
            }
            else
            {
                IsTurn2 = true;
            }
        }


        //&& bbb.IsBallOut
       /* if (bbb.IsBallOut)
        {
            Instantiate(ball, BallLocation.transform.position, Quaternion.identity);
            IsTurn2 = false;
            IsStartOfFrame = true;
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
        /*if (NeedNewBall)
        {
            Instantiate(ball, BallLocation.transform.position, Quaternion.identity);
            NeedNewBall = false;

            
        }*/
        
        
        //IsTurn2 = false;

        // Puts all the pins on the alley at the start of the frame
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
