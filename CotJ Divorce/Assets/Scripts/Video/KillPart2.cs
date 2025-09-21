using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class KillPart2 : MonoBehaviour
{
    private VideoPlayer VP;
    public static UnityEvent onVideoEnd = new UnityEvent();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VP = gameObject.GetComponent<VideoPlayer>();

        VP.loopPointReached += VideoDone;
        VP.loopPointReached += ctx => { onVideoEnd.Invoke(); };
    }

    private void VideoDone(VideoPlayer vp)
    {
        Destroy(gameObject);
    }
}
