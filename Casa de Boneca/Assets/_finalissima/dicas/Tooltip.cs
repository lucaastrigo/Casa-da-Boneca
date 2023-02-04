using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public bool on;
    [HideInInspector] public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Toggle()
    {
        if (on) anim.SetTrigger("off");
        if (!on) anim.SetTrigger("on");

        on = !on;
    }
}
