using UnityEngine;

public class BowlingBallBehaviour : MonoBehaviour
{
    private BowlingPinBehaviour bp;
    private BowlingController bc;

    public Rigidbody rb;
    public float speed = 1;
    public float MovementSpeed = 5;

  

    public bool IsBallThrown;
    public bool IsBallOut;
    public bool CanThrow;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //  bp = GameObject.Find("BowlingPinBehaviour").GetComponent<BowlingPinBehaviour>();
        //bc = GameObject.Find("BowlingController").GetComponent<BowlingController>();
        bc = FindFirstObjectByType<BowlingController>();
        IsBallThrown = false;
        IsBallOut = false;
        CanThrow = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (CanThrow)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                IsBallThrown = true;
                CanThrow = false;
            }
        }
        

        Bowl();

        PlayerMove();
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

    void PlayerMove()
    {
        Debug.Log("move");
        float xMove = Input.GetAxis("Horizontal");
        Debug.Log(xMove);
        Vector3 movement = new Vector3(xMove, 0f);

        movement *= Time.deltaTime * MovementSpeed;

        transform.position += movement;
    }

    private void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.tag == "EndOfTheLine")
        {

            IsBallOut = true;
            Debug.Log("is ball out");
            bc.NeedNewBall = true;
            Debug.Log("Need new ball");
            CanThrow = true;
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

