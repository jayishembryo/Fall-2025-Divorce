using UnityEngine;

public class BowlingBallBehaviour : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 1;

    public GameObject BowlingBall;

    public bool IsBallThrown;
    public bool IsBallOut;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsBallThrown = false;
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
        if (IsBallOut)
        {

        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        //getting rid of a life, playing a sound, and deleting an enemy when it hits the finish
        // line or player 
        if (collision.gameObject.tag == "EndOfTheLine")
        {
            IsBallOut = true;
            Destroy(this.gameObject);
        }


    }

}

