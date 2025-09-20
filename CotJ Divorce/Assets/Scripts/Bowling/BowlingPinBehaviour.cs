using UnityEngine;

public class BowlingPinBehaviour : MonoBehaviour
{
    private BowlingController bc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bc = GameObject.Find("BowlingController").GetComponent<BowlingController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //getting rid of a life, playing a sound, and deleting an enemy when it hits the finish
        // line or player 
        if (collision.gameObject.tag == "ball")
        {
            BowlingController.PinsHit = BowlingController.PinsHit + 1;
            Debug.Log(BowlingController.PinsHit);
            Destroy(this.gameObject);
        }
        

        }

    }

