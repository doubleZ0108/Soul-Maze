using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;//注意这个不能少
//using UnityEditor.Sprites;
using UnityEngine;


public class MusicButtonClick : MonoBehaviour
{
    public Sprite music;//定义待用的按钮图标
    public Sprite slience;
    public GameObject audioListener;

    public bool isMute = false;

    void Start()
    {
        this.GetComponent<Image>().sprite = music;
        isMute = false;
    }

    public void ClickMusicButton()
    {
        if (!isMute)
        {
            musicChange.toggleMusic();
            audioListener.GetComponent<AudioSource>().volume = 0;

            this.GetComponent<Image>().sprite = slience;
            isMute = true;
        }
        else
        {
            audioListener.GetComponent<AudioSource>().volume = 0.6f;
            musicChange.toggleMusic();
            
            this.GetComponent<Image>().sprite = music;
            isMute = false;
        }
    }

    public void InitialClickMusicButton()
	{
        if (!isMute)
        {
            //musicChange.toggleMusic();
            audioListener.GetComponent<AudioSource>().volume = 0;

            this.GetComponent<Image>().sprite = slience;
            isMute = true;
        }
        else
        {
            audioListener.GetComponent<AudioSource>().volume = 0.6f;
            //musicChange.toggleMusic();

            this.GetComponent<Image>().sprite = music;
            isMute = false;
        }
    }
}
