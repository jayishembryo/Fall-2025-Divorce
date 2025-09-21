using System.Collections.Generic;
using UnityEngine;

public class PinFallDetection : MonoBehaviour
{
    public GameObject PinFallBox;
    public BowlingPinBehaviour bp;
    public List<GameObject> Birds;
    public Transform StartingPoint;
    public float speed = 5;
    //Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //this'n
       // bp = GameObject.Find("BowlingPinBehaviour").GetComponent<BowlingPinBehaviour>();
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
                bp.Hit = true;
                // maybe put hit counted false here
                Debug.Log("The pin should be invisible");
                //turning the hit box off so it doesn't double count if the pins rolls
                this.gameObject.SetActive(false);
                // sky this line might break your code

                //hi jacqueline, this is for spawning window birds
                GameObject instantiatedObject = Instantiate(Birds[Random.Range(0, Birds.Count)], StartingPoint.position + new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0), Quaternion.identity);
                instantiatedObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, -speed);


                //BowlingController.PinsHit = BowlingController.PinsHit + 1;
                //Debug.Log(BowlingController.PinsHit);
               /* bp.Hit = true;
                // maybe put hit counted false here
                Debug.Log("The pin should be invisible");
                this.gameObject.SetActive(false);
*/




            }
            

        }


    }
}
