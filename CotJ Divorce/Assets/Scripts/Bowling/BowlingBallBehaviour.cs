using UnityEngine;

public class BowlingBallBehaviour : MonoBehaviour
{
    private BowlingPinBehaviour bp;
    private BowlingController bc;

    public Rigidbody rb;
    public float speed = 1;

  

    public bool IsBallThrown;
    public bool IsBallOut;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //  bp = GameObject.Find("BowlingPinBehaviour").GetComponent<BowlingPinBehaviour>();
        //bc = GameObject.Find("BowlingController").GetComponent<BowlingController>();
        bc = FindFirstObjectByType<BowlingController>();
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

            if(!bc.IsTurn2 && IsBallOut)
            {
                bc.IsTurn2 = true;
                Debug.Log("Is Turn 2");
            }
           
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
            Debug.Log("is ball out");
            bc.NeedNewBall = true;
            Debug.Log("Need new ball");
            /*if (!bc.IsTurn2)
            {
                bc.IsTurn2 = true;
                Debug.Log("IsTurn2 " + bc.IsTurn2);
            }*/
            Debug.Log("Ball Deleted");
            Destroy(this.gameObject);
        }


    }

}

