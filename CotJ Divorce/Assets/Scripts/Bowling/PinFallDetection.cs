using UnityEngine;

public class PinFallDetection : MonoBehaviour
{
    public GameObject PinFallBox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // PinFallBox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject.tag == "Floor")
        {

            if (!BowlingPinBehaviour.Hit)
            {
                // if (!BowlingPinBehaviour.HitCounted)
                // {
                BowlingController.PinsHit = BowlingController.PinsHit + 1;
                Debug.Log(BowlingController.PinsHit);
                this.gameObject.SetActive(false);
                BowlingPinBehaviour.Hit = true;
               
                //}
                   

            }
            

        }


    }
}
