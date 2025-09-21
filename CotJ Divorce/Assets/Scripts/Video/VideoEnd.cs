using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEnd : MonoBehaviour
{
    public static bool VideoIsOver = false;
    public static UnityEvent onVideoEnd = new UnityEvent();
    private VideoPlayer vp;
    public string NextScene;
    private BowlingController BC;
    public MeshRenderer MR;
    private void Awake()
    {
        vp = GetComponent<VideoPlayer>();
        vp.loopPointReached += VideoDone;
        vp.loopPointReached += ctx => { onVideoEnd.Invoke(); };
        BC = FindFirstObjectByType<BowlingController>();
    }

    private void Update()
    {
        if (BC.AmountOfTimesBowled >= 3)
        {
            //MR AND VP
            MR.enabled = true;
            vp.enabled = true;
        }
    }

    private void VideoDone(VideoPlayer vp)
    {
        VideoIsOver = true;
        SceneManager.LoadScene(NextScene);
    }
}
