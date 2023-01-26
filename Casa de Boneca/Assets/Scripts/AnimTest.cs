using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{
    public enum testType 
    {
        progress, tips
    }

    public testType type;


    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (type == testType.progress)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                anim.SetTrigger("play");
            }
        }
        else if (type == testType.tips)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                anim.SetTrigger("play");
            }
        }
    }
}
