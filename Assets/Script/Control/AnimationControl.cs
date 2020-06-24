using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class AnimationControl : MonoBehaviour
{
    GameObject myAnimation;
    GameObject skipButton;
    VideoPlayer videoPlayer;
    float controlTime;

    // Start is called before the first frame update
    void Start()
    {
        myAnimation = GameObject.Find("MyAnimation");
        videoPlayer = myAnimation.GetComponent<VideoPlayer>();
        skipButton = GameObject.Find("SkipButton");

        skipButton.GetComponent<Button>().onClick.AddListener(startGame);
        
        String sceneName = SceneManager.GetActiveScene().name;
        Debug.Log(sceneName);
        if (sceneName == "StartAnimation")
        {
            controlTime = 53;
        } else if (sceneName == "FailAnimation")
        {
            controlTime = 10.5f;
        } else
        {
            controlTime = 23.0f;
        }
        Debug.Log(controlTime);
    }


    void startGame()
    {
        videoPlayer.Pause();
        Debug.Log("skip");
        SceneManager.LoadScene("InitialLevelScene");
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(videoPlayer.time);
        if (videoPlayer.time >= controlTime)
        {
            Debug.Log("change");
            SceneManager.LoadScene("InitialLevelScene");
        }
    }
}
