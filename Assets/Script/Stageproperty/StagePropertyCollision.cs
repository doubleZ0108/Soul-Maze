using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class StagePropertyCollision : MonoBehaviour
{
    public static void SanCollision()
	{
		Hero._san += 20;
	}

    public static void HeartCollision()
	{
		Hero._hp += 1;
	}

    public static void FragmentCollision(Collision collision)
	{
		Fragment fragment = new Fragment(collision.gameObject.tag);
		Hero._fragments.Add(fragment);
	}

    public static void AIThirdPersonCollision(Transform spirit, Collision collision)
	{
		Debug.Log("moster hit me");
		Hero._hp -= 1;
		Destroy(collision.gameObject);

		spirit.GetComponent<AIMain>().GenerateNewAI(collision.gameObject.tag);

		//Vector3 randPos = new Vector3(Random.Range(-80.0f, 80.0f), 0.0f, Random.Range(-80.0f, 80.0f));
		//collision.gameObject.transform.position = randPos;
	}

    public static void AIBossCollision()
	{
		//受伤动画
		if (AIBossCharacterControl.EatHeroCallBack())
		{
			Hero._hp -= 3;
		}
	}
}


