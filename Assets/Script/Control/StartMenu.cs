using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    GameObject miniMap;
    GameObject startCamera;
    GameObject initialButton;
    GameObject startButton;
    GameObject startCanvas;
    GameObject controlGroup;
    GameObject stopButton;
    GameObject sanHeartFrag;
    GameObject aIThirdPersonController;
    GameObject thirdPersonController;
    GameObject nextButton;
    GameObject exitButton;


    // Start is called before the first frame update
    void Start()
    {
        miniMap = GameObject.Find("MessageCanvas");
        initialButton = GameObject.Find("InitialButton");
        startCamera = GameObject.Find("StartCamera");
        startCanvas = GameObject.Find("StartCanvas");
        startButton = GameObject.Find("StartButton");
        controlGroup = GameObject.Find("ControlGroup");
        //stopButton = GameObject.Find("PauseButton");
        sanHeartFrag = GameObject.Find("SanHeartFrag");
        aIThirdPersonController = GameObject.Find("AIThirdPersonController");
        thirdPersonController = GameObject.Find("ThirdPersonController");
        nextButton = GameObject.Find("nextButton");
        exitButton = GameObject.Find("ExitButton");



        miniMap.SetActive(false);
        controlGroup.SetActive(false);
        sanHeartFrag.SetActive(false);
        aIThirdPersonController.SetActive(false);
        thirdPersonController.SetActive(false);

        initialButton.GetComponent<Button>().onClick.AddListener(initialGame);
        startButton.GetComponent<Button>().onClick.AddListener(startGame);
        //stopButton.GetComponent<Button>().onClick.AddListener(stopGame);
        nextButton.GetComponent<Button>().onClick.AddListener(startGame);
        exitButton.GetComponent<Button>().onClick.AddListener(exitGame);
    }


    void initialGame()    {        startCanvas.SetActive(false);        Tweener tweener1 = startCamera.transform.DOBlendableLocalMoveBy(new Vector3(-7.2f, 8f, 3f), 2);        startCamera.transform.DOBlendableLocalRotateBy(new Vector3(20, 40, 0), 1);        tweener1.OnComplete(continueMove);    }    void continueMove()    {        Tweener tweener2 = startCamera.transform.DOBlendableLocalMoveBy(new Vector3(0, -8f, 3f), 2);        startCamera.transform.DOBlendableLocalRotateBy(new Vector3(5, 0, 0), 1);        tweener2.OnComplete(changeCamera);    }


    void startGame()
    {
        startCanvas.SetActive(false);
        SceneManager.LoadScene("LevelOne");
    }


    void changeCamera()
    {
        miniMap.SetActive(true);
        sanHeartFrag.SetActive(true);
        aIThirdPersonController.SetActive(true);
        thirdPersonController.SetActive(true);

        controlGroup.SetActive(true);
        startCamera.SetActive(false);
    }
    

    void stopGame()
    {
        // 调用暂停函数
        stopButton.GetComponent<GamePauseScript>().stopGame();
        // 设置蒙版

    }


    void exitGame()
	{
#if UNITY_EDITOR       UnityEditor.EditorApplication.isPlaying = false;#else        Application.Quit();#endif
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

