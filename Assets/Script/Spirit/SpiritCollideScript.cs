using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritCollideScript : MonoBehaviour
{
    private string[] nonCollisionStore = { "Plane", "Wall", "TreeLight", "StoneLight","Rock6", "AIBoss" };

    void OnCollisionEnter(Collision collision)
    {
        string collisedName = collision.gameObject.name;

        if (string.Equals(collisedName, "FireLightDark"))
        {
            StagePropertyCollision.SanCollision();
        }
        else if(string.Equals(collisedName, "HeartToCatch"))
		{
            StagePropertyCollision.HeartCollision();
        }
        else if (string.Equals(collisedName, "FragmentDark"))
        {
            StagePropertyCollision.FragmentCollision(collision);
        }
        else if (string.Equals(collisedName, "AIThirdPersonController"))
        {
            StagePropertyCollision.AIThirdPersonCollision(this.transform, collision);
        }
        else if(string.Equals(collisedName, "AIBoss"))
		{
            StagePropertyCollision.AIBossCollision();
		}


        if (!((IList)nonCollisionStore).Contains(collisedName))
		{
            Destroy(collision.gameObject);
        }
        
    }
}
