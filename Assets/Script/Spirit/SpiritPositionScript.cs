using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritPositionScript : MonoBehaviour
{
    CharacterController spirit;
    public float gravity = 9.8f;

    void Start()
    {
        spirit = GetComponent<CharacterController>();
    }

    void DownToGround()
    {
        if (!spirit.isGrounded)
        {
            Vector3 moveVec = new Vector3(0, 0, 0);
            moveVec += Vector3.down * gravity * Time.deltaTime;
        }
    }

    void Update()
    {
        DownToGround();
    }
}
