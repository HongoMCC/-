using UnityEngine;
using UnityEngine.Video;

public class VideoEndScript : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Inspectorで動画を設定

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    void OnVideoEnded(VideoPlayer vp)
    {
        Application.Quit(); // アプリケーションを終了
    }
}
