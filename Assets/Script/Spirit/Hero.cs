using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    private static int __hp;

    //Hero._hp
    public static int _hp {
		get
		{
            return __hp;
		}
        set
		{
            __hp = value;
            if(__hp > _maxHp) { __hp = _maxHp; }

            if(__hp > 0)
			{
                __hp = value;
                if (__hp > _maxHp) { __hp = _maxHp; }
            }
            else
			{
                Debug.Log("hp ==== 0");
                SceneManager.LoadScene("FailAnimation");
            }
		}
    }

    public static int _maxHp { get; set; }
    private static int __san;
    //Hero._san
    public static int _san {
		get
		{
            return __san;
		}
        set
		{
            if(__san > 0)
			{
                musicChange.SanEnough();
                __san = value;
                if(__san > 100) { __san = 100; }
			}
            else
			{
                musicChange.SanTooLow();
                Debug.Log("san ==== 0");
			}
		}
    }
    public static float _speedMultiper { get; set; }
    public static List<Fragment> _fragments = new List<Fragment>();

    public static void initHero()
	{
        Hero._maxHp = 5;
        Hero.__hp = _maxHp;
        Hero.__san = 100;
        Hero._speedMultiper = 1.0f;
        Hero._fragments = new List<Fragment>();

    }
}
