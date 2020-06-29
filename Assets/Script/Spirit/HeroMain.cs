using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;


public class HeroMain : MonoBehaviour
{
    public GameObject sceneLight;
    public float maxLightIntensity;
    public float minLightIntensity;

    private static bool isPause = false;
    private float sanTimer = 1.0f;

    //heart san fragment
    private GameObject[] heartsFull;
    private GameObject[] fragments;
    private int frg;
    private int hp;
    private GameObject sanFill;
    private string[] hpName={"HeartF5","HeartF4","HeartF3","HeartF2","HeartF1"};
    private string[] fragName={"Yellow","Orange","Green","Blue","Pink","Cyan","Red","Purple","Silver"};
    private float territoryBorder = 40.0f;

    void Start()
    {
        Hero.initHero();
        //StartCoroutine(HeroSanTimer());

        //StopCoroutine("HeroSanTimer");

        //heart san fragment
        heartsFull = new GameObject[5];
        fragments= new GameObject[9];
        for(int i=0;i<5;i++)
        {
            heartsFull[i]=GameObject.Find(hpName[i]);
        }
        for(int i=0;i<9;i++)
        {
            fragments[i]=GameObject.Find(fragName[i]);
        }
        //fragments = GameObject.FindGameObjectsWithTag("Fragment");
        frg = 0;
        hp = Hero._maxHp;
        sanFill = GameObject.Find("Fill");
        initFrg();
    }

    void Update()
    {
        if (isHeroInTerritory())
        {
            musicChange.BigAlarm();
        }
        else
        {
            musicChange.DeleteBigAlarm();
        }

        if (!isPause)
        {
            sanTimer -= Time.deltaTime;
            if(sanTimer < 0)
			{
                Hero._san -= 1;
                sanTimer = 1.0f;
            }
            //刷新碎片状态
            updateFrg();

            if (frg == 9)
            {
                // 游戏结束！！
                if(SceneManager.GetActiveScene().name == "LevelOne")
                {
                    SceneManager.LoadScene("SuccessAnimation");
                }
            }

            // 根据san动态调整speed multiplier
            this.GetComponent<ThirdPersonCharacter>().m_MoveSpeedMultiplier = (float)(0.8 * Hero._san / 100 + 0.4);

			// 根据san动态调整 light 二选一
			// san越低 场景越黑
			//sceneLight.GetComponent<Light>().intensity = (float)(1.0 * (maxLightIntensity - minLightIntensity) / 100 * Hero._san + minLightIntensity);

			// san越低 场景越亮
			sceneLight.GetComponent<Light>().intensity = (float)(1.0 * (minLightIntensity - maxLightIntensity) / 100 * Hero._san + maxLightIntensity);
		}
        else
        {
            //停止san变化
        }

    }

    private void initFrg()
    {
        for (int i = 0; i < 9; i++)
        {
            fragments[i].SetActive(false);
        }
    }

    //更新碎片获取状态
    private void updateFrg()
    {
        int frgCount = Hero._fragments.Count;
        if (frg != frgCount)
        {
            string frgName = Hero._fragments[frgCount - 1]._name;
            int len = frgName.Length;
            Debug.Log(frgName);
            frgName = frgName.Substring(len - 1, 1);
            Debug.Log(frgName);
            int num = int.Parse(frgName);
            fragments[num - 1].SetActive(true);

        }
        frg = frgCount;
    }

    private void OnGUI()
    {
        /*
        Rect area = new Rect(10.0f, 10.0f, 300.0f, 100.0f);
        GUILayout.BeginArea(area);

        GUILayout.Label("HP: " + Hero._hp.ToString());
        GUILayout.Label("San: " + Hero._san.ToString());

        GUILayout.EndArea();
        */
        if (hp != Hero._hp)
        {
            hp = Hero._hp;
            int counter = Hero._maxHp - Hero._hp;
            for (int i = 0; i < Hero._maxHp; i++)
            {
                if (i < hp)
                {
                    heartsFull[i].SetActive(true);
                }
                else
                {
                    heartsFull[i].SetActive(false);
                }

            }
        }
        if (true)
        {
            // sanRate=Hero._san/100;
            float sanLen = 160 * Hero._san / 100;
            sanFill.transform.localPosition = new Vector3(sanLen / 2 - 80, 0, 0);
            sanFill.GetComponent<RectTransform>().sizeDelta = new Vector2(sanLen, 10);
            //Debug.Log(sanFill.GetComponent<RectTransform>().sizeDelta);
        }
    }

    //IEnumerator HeroSanTimer()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1.0f);
    //        Hero._san -= 1;
    //    }
    //}

    public static void togglePause()
    {
        isPause = !isPause;
    }

    private bool isHeroInTerritory()
    {

        return (this.transform.position.x > -territoryBorder && this.transform.position.x < territoryBorder
                && this.transform.position.z > -territoryBorder && this.transform.position.z < territoryBorder);

    }
}