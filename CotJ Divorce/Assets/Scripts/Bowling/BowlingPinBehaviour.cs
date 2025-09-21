using System.Collections.Generic;
using UnityEngine;

public class BowlingPinBehaviour : MonoBehaviour
{
    private BowlingController bc;
    private BowlingBallBehaviour bbb;
    public bool Hit;
    public bool HitCounted;

    [SerializeField] List<AudioClip> birdSounds = new List<AudioClip>();

    [SerializeField] AudioSource glassSource;
    [SerializeField] AudioSource playerSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bc = FindFirstObjectByType<BowlingController>();
        bbb = FindFirstObjectByType<BowlingBallBehaviour>();
        //bc = GameObject.Find("BowlingController").GetComponent<BowlingController>();
        //  bbb = GameObject.Find("BowlingBallBehaviour").GetComponent<BowlingBallBehaviour>();
        Hit = false;
        HitCounted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Hit)
        {
            if (!HitCounted)
            {
                BowlingController.PinsHit = BowlingController.PinsHit + 1;
                Debug.Log(BowlingController.PinsHit);
             

                glassSource.Play();

                int randomClip = Random.Range(0, birdSounds.Count);
                playerSource.clip = birdSounds[randomClip];
                playerSource.Play();

                FindFirstObjectByType<BowlingController>().PauseAnimators();

                HitCounted = true;
            }

            if(bbb.IsBallOut)
            {
                Debug.Log("This pin should be deleted");
                Destroy(this.gameObject);
            }
            

        }

        if (bc.IsStartOfFrame)
        {
            Destroy(this.gameObject);
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        //getting rid of a life, playing a sound, and deleting an enemy when it hits the finish
        // line or player 
        if (collision.gameObject.tag == "ball")
        {
            /*BowlingController.PinsHit = BowlingController.PinsHit + 1;
            Debug.Log(BowlingController.PinsHit);
            Hit = true;*/

           /* if (BowlingBallBehaviour.IsBallOut)
            {
                Destroy(this.gameObject);
            }*/

        }

    }

}

