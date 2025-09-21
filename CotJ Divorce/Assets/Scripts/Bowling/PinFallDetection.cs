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

                //hi jacqueline, this is for spawning window birds
                GameObject instantiatedObject = Instantiate(Birds[Random.Range(0, Birds.Count - 1)], StartingPoint.position, Quaternion.identity);
                instantiatedObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, speed);


                //BowlingController.PinsHit = BowlingController.PinsHit + 1;
                //Debug.Log(BowlingController.PinsHit);
                this.gameObject.SetActive(false);
                bp.Hit = true;



            }
            

        }


    }
}
