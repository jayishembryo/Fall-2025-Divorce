using UnityEngine;

public class PinFallDetection : MonoBehaviour
{
    public GameObject PinFallBox;
    public BowlingPinBehaviour bp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // PinFallBox.SetActive(true);
        bp = GameObject.Find("BowlingPinBehaviour").GetComponent<BowlingPinBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject.tag == "Floor")
        {

            if (!bp.Hit)
            {
                
                //BowlingController.PinsHit = BowlingController.PinsHit + 1;
                //Debug.Log(BowlingController.PinsHit);
                this.gameObject.SetActive(false);
                bp.Hit = true;
               
               
                   

            }
            

        }


    }
}
