using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class vbtn : MonoBehaviour
{
    public GameObject video;
    public VirtualButtonBehaviour vb;
    private VideoPlayer videoPlayer;
    public GameObject tmp_paused;
    void Start()
    {
        videoPlayer = video.GetComponent<VideoPlayer>();
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
       
    }
    private void Update()
    {
        if (videoPlayer.isPlaying)
        {
            tmp_paused.SetActive(false);
        }
        else
        {
            tmp_paused.SetActive(true);
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour obj)
    {
    }

    public void OnButtonPressed(VirtualButtonBehaviour obj)
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            tmp_paused.SetActive(true);
        }
        else
        {
            videoPlayer.Play();
            tmp_paused.SetActive(false);
        }
    }


}
