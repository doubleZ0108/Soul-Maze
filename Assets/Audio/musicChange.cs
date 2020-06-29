using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicChange : MonoBehaviour
{
    //存放音频的数组
    public AudioClip[] audios;
    private static AudioSource bgmAudio;

    public static bool alarmBig = false;
    public static bool alarmSmall = false;
    public static bool lowSan = false;
    public static bool lowSanPre = false;

    public static float bgmChangeSpeed = 0.6f;

    private int targetVolume = 0;
    private bool canChange = false;

    private static bool startAudioalarmBig = true;
    private static bool startAudioalarmSmall = true;

    public static bool musicOn = true;
    private static float volumn;
    // Use this for initialization
    void Start()
    {
        //默认播放第1个音频
        bgmAudio = this.GetComponent<AudioSource>();
        bgmAudio.clip = audios[0];
        alarmBig = false;
        bgmAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (musicOn)
        {
            if (alarmBig)
            {
                if (startAudioalarmBig)
                {
                    bgmAudio.volume = 0.6f;
                    bgmAudio.clip = audios[3];
                    bgmAudio.Play();
                    //startAudioalarmSmall = false;
                    startAudioalarmBig = false;
                }
                if (lowSan)
                {
                    targetVolume = 0;
                    canChange = false;
                }
                else
                {
                    targetVolume = 1;
                    canChange = false;
                }
            }
            else
            {
                if (lowSan)
                {
                    //Debug.Log("=====LowSanMusic!!!");                 
                    //如果当前声音是小的，目标声音是1，则切换声音文件
                    Debug.Log("volumn=" + bgmAudio.volume);
                    if (bgmAudio.volume <= 0.05 && targetVolume == 1)
                    {
                        // 在衰减途中切换了状态
                        if (lowSan != lowSanPre)
                        {
                            lowSan = lowSanPre;
                            targetVolume = 0;
                        }
                        //lowSan = lowSanPre;
                        else
                        {
                            bgmAudio.clip = audios[1];
                            canChange = true;//可以切换
                            bgmAudio.Play();
                            //startAudioalarmSmall = true;
                            startAudioalarmBig = true;
                        }

                    }
                    //如果当前声音是正常的，并且目标声音是0，是否可以改变为false
                    if (bgmAudio.volume > 0.05 && targetVolume == 0 && canChange == false)
                    {
                        //将声音渐变到0
                        Debug.Log("decrease music");
                        bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume, Time.deltaTime * bgmChangeSpeed);
                        if (bgmAudio.volume <= 0.05)
                        {
                            targetVolume = 1;
                        }
                    }
                    //如果当前声音目标是1，并且可以切换
                    if (targetVolume == 1 && canChange)
                    {
                        //将声音渐变到1
                        bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume, Time.deltaTime * bgmChangeSpeed);
                        if (bgmAudio.volume >= 0.6)
                        {
                            canChange = false;
                        }
                    }
                    //SirenOnPlay();
                }
                else
                {
                    //声音切换渐变大法
                    if (bgmAudio.volume <= 0.05 && targetVolume == 0)
                    {
                        if (lowSan != lowSanPre)
                        {
                            lowSan = lowSanPre;
                            targetVolume = 1;
                        }
                        else
                        {
                            bgmAudio.clip = audios[0];
                            canChange = true;
                            bgmAudio.Play();
                            //startAudioalarmSmall = true;
                            startAudioalarmBig = true;
                            lowSan = lowSanPre;
                        }

                    }
                    if (bgmAudio.volume > 0.05 && targetVolume == 1 && canChange == false)
                    {
                        bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume - 1, Time.deltaTime * bgmChangeSpeed);
                        if (bgmAudio.volume <= 0.05)
                        {
                            targetVolume = 0;
                        }
                    }

                    if (targetVolume == 0 && canChange)
                    {
                        bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume + 1, Time.deltaTime * bgmChangeSpeed);
                        if (bgmAudio.volume >= 0.6)
                        {
                            canChange = false;
                        }
                    }
                    //}
                }
            }
        }
        else
        {
            bgmAudio.volume = 0f;
        }

        //}
        //else
        //{
        //        if (lowSan)
        //        {
        //            //Debug.Log("=====LowSanMusic!!!");                 
        //            //如果当前声音是小的，目标声音是1，则切换声音文件
        //            //Debug.Log("volumn=" + bgmAudio.volume);
        //            if (bgmAudio.volume <= 0.05 && targetVolume == 1)
        //            {
        //                // 在衰减途中切换了状态
        //                if (lowSan != lowSanPre)
        //                {
        //                    lowSan = lowSanPre;
        //                    targetVolume = 0;
        //                }
        //                //lowSan = lowSanPre;
        //                else
        //                {
        //                    bgmAudio.clip = audios[1];
        //                    canChange = true;//可以切换
        //                    bgmAudio.Play();
        //                    startAudioalarmSmall = true;
        //                    startAudioalarmBig = true;
        //                }

        //            }
        //            //如果当前声音是正常的，并且目标声音是0，是否可以改变为false
        //            if (bgmAudio.volume > 0.05 && targetVolume == 0 && canChange == false)
        //            {
        //                //将声音渐变到0
        //                Debug.Log("decrease music");
        //                bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume, Time.deltaTime * bgmChangeSpeed);
        //                if (bgmAudio.volume <= 0.05)
        //                {
        //                    targetVolume = 1;
        //                }
        //            }
        //            //如果当前声音目标是1，并且可以切换
        //            if (targetVolume == 1 && canChange)
        //            {
        //                //将声音渐变到1
        //                bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume, Time.deltaTime * bgmChangeSpeed);
        //                if (bgmAudio.volume >= 0.6)
        //                {
        //                    canChange = false;
        //                }
        //            }
        //            //SirenOnPlay();
        //        }
        //        else
        //        {
        //            //声音切换渐变大法

        //            if (bgmAudio.volume <= 0.05 && targetVolume == 0)
        //            {
        //                if (lowSan != lowSanPre)
        //                {
        //                    lowSan = lowSanPre;
        //                    targetVolume = 1;
        //                }
        //                else
        //                {
        //                    bgmAudio.clip = audios[0];
        //                    canChange = true;
        //                    bgmAudio.Play();
        //                    startAudioalarmSmall = true;
        //                    startAudioalarmBig = true;
        //                    lowSan = lowSanPre;
        //                }

        //            }
        //            if (bgmAudio.volume > 0.05 && targetVolume == 1 && canChange == false)
        //            {
        //                bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume - 1, Time.deltaTime * bgmChangeSpeed);
        //                if (bgmAudio.volume <= 0.05)
        //                {
        //                    targetVolume = 0;
        //                }
        //            }

        //            if (targetVolume == 0 && canChange)
        //            {
        //                bgmAudio.volume = Mathf.Lerp(bgmAudio.volume, targetVolume + 1, Time.deltaTime * bgmChangeSpeed);
        //                if (bgmAudio.volume >= 0.6)
        //                {
        //                    canChange = false;
        //                }
        //            }
        //        //}
        //    }
        //}

        
    }



    public static void BigAlarm()
    {
        alarmBig = true;
    }
    public static void DeleteBigAlarm()
    {
        alarmBig = false;
    }
    public static void SmallAlarm()
    {
        alarmSmall = true;
    }
    public static void DeleteSmallAlarm()
    {
        alarmSmall = false;
    }
    public static void SanTooLow()
    {
        //Debug.Log("LowSanStart,lowSan=" + lowSan);
        lowSanPre = true;
        //if (canChange)
        //{
        lowSan = true;
        //}
    }
    public static void SanEnough()
    {
        lowSanPre = false;
        //if (canChange)
        //{
        lowSan = false;
        //}
    }

    public static void toggleMusic()
    {
        if (musicOn)
        {
            volumn = bgmAudio.volume;
        }
        else
        {
            bgmAudio.volume = volumn;
        }
        musicOn = !musicOn;
    }
}