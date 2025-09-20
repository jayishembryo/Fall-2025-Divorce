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
    private void Awake()
    {
        vp = GetComponent<VideoPlayer>();
        vp.loopPointReached += VideoDone;
        vp.loopPointReached += ctx => { onVideoEnd.Invoke(); };
    }

    private void VideoDone(VideoPlayer vp)
    {
        VideoIsOver = true;
        SceneManager.LoadScene(NextScene);
    }
}
