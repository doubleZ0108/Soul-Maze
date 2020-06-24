using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMain : MonoBehaviour
{
    public GameObject AIprefab;
    public bool isInit;
    public static int maxAINum = 8;
    private GameObject[] AIs = new GameObject[maxAINum];

    // Start is called before the first frame update
    void Start()
    {
        AIs[0] = AIprefab;
        if(isInit==false)
        {
            for (int index = 1; index < maxAINum; ++index)
            {
                CreateAI(index, true);
            }
        }
    }

    public void GenerateNewAI(string whichAIName)
	{
        if(isInit==false)
        {
            int index = int.Parse(whichAIName.Substring(whichAIName.Length - 1, 1));
            CreateAI(index, false);
        }
    }

    void CreateAI(int index, bool usePrefabFlag)
	{
        Vector3 randPos = new Vector3(Random.Range(-80.0f, 60.0f), 0.0f, Random.Range(-60.0f, 80.0f));

		if (usePrefabFlag)
		{
            AIs[index] = Instantiate<GameObject>(AIprefab, randPos, transform.rotation);
            AIs[index].name = AIprefab.name;
        }
        else
		{
            AIs[index] = Instantiate<GameObject>(AIs[maxAINum - 1 - index], randPos, transform.rotation);
            AIs[index].name = AIs[maxAINum - 1 - index].name;
        }
        AIs[index].tag = "ai" + index.ToString();
    }
}
