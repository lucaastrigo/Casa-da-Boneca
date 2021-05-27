using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abajur : MonoBehaviour
{
    public GameObject Xadez;

    float shakeTime;
    Vector3 accelerationInput;

    private bool foi;
    private void Start()
    {
        //
    }

    void Update()
    {
        accelerationInput = Input.acceleration;

        if (!foi)
        {
            if (accelerationInput.sqrMagnitude >= 5f)
            {
                shakeTime += Time.deltaTime;
                if (shakeTime > 0.3f)
                {

                    Xadez.SetActive(true);
                    foi = true;
                }
            }
        }


    }
}
