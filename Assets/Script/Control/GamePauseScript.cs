using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class GamePauseScript : MonoBehaviour
{
    GameObject stopCanvas;
    GameObject stopMask;
    GameObject continueButton;
    GameObject backButton;
    GameObject returnButton;

    private void Start()
    {
        stopCanvas = GameObject.Find("StopCanvas");
        stopMask = GameObject.Find("StopMask");
        continueButton = GameObject.Find("ContinueButton");
        backButton = GameObject.Find("BackButton");
        returnButton = GameObject.Find("ReturnButton");

        stopCanvas.SetActive(false);
        stopMask.GetComponent<Image>().color = new Color(255, 255, 255, 0.8f);
        continueButton.GetComponent<Button>().onClick.AddListener(continueGame);
        backButton.GetComponent<Button>().onClick.AddListener(backToMenu);
        returnButton.GetComponent<Button>().onClick.AddListener(backToMenu);

        this.gameObject.GetComponent<Button>().onClick.AddListener(stopGame);
    }


    public void continueGame()
    {
        stopCanvas.SetActive(false);
        togglePause();
    }


    public void stopGame()
    {
        stopCanvas.SetActive(true);
        togglePause();
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("InitialLevelScene");
    }


    public void togglePause()
	{
        HeroMain.togglePause();
        AICharacterControl.togglePause();
        AIBossCharacterControl.togglePause();
        ThirdPersonUserControl.togglePause();
	}
}
