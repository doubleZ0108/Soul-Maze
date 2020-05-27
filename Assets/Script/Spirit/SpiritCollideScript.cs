using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritCollideScript : MonoBehaviour
{
    private int CrashNum = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane" && collision.gameObject.name != "Wall")
        {
            CrashNum += 1;
            Destroy(collision.gameObject);
        }
    }

    private void OnGUI()
    {
        Rect area = new Rect(10.0f, 10.0f, 300.0f, 40.0f);
        GUILayout.BeginArea(area);

        GUILayout.Label("Crashed: " + CrashNum.ToString());

        GUILayout.EndArea();
    }
}
