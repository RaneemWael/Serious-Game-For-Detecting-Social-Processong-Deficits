using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playVid : MonoBehaviour
{
    public VideoPlayer v;
    
    public void Awake()
    {
        v.url = System.IO.Path.Combine(Application.streamingAssetsPath, "ThumbsUp.mp4");
        v.Play();
    }
}
