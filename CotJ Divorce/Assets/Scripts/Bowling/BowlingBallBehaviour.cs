using UnityEngine;

public class BowlingBallBehaviour : MonoBehaviour
{
    private BowlingPinBehaviour bp;

    public Rigidbody rb;
    public float speed = 1;

  

    public bool IsBallThrown;
    public static bool IsBallOut;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      //  bp = GameObject.Find("BowlingPinBehaviour").GetComponent<BowlingPinBehaviour>();
        IsBallThrown = false;
        IsBallOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsBallThrown = true;
        }

        Bowl();
    }

    public void Bowl()
    {
        if (IsBallThrown)
        {
            //bowling ball go forward -> apply the velocity instead of doing it 1 update at a time, forcemode.impulse 
            rb.AddForce(transform.forward * speed, ForceMode.Impulse);
            Debug.Log("Throw the ball");
            IsBallThrown = false;
        }
        else
        {
           // Debug.Log("GUTTTTTER");
        }

        
    }

    public void BowlAgain()
    {
        /*if (IsBallOut)
        {

        }*/
    }

    private void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.tag == "EndOfTheLine")
        {
            IsBallOut = true;
            Destroy(this.gameObject);
        }


    }

}

