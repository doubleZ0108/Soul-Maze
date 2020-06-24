using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] sign;
    private int sgnCounter;
    private float lastTime;
    void Start()
    {
        sign = GameObject.FindGameObjectsWithTag("Sign");
        SignInit();
        sgnCounter=0;
        lastTime = Time.time;
    }
    private void SignInit(){
        for (int i = 1; i < 5; i++)
        {
            sign[i].SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if((sgnCounter<5)&&((Time.time - lastTime) > 5)){
            sign[sgnCounter].SetActive(false);
            sgnCounter+=1;
            if(sgnCounter<5){
                sign[sgnCounter].SetActive(true);
            }
            lastTime = Time.time;
        }
    }
}
