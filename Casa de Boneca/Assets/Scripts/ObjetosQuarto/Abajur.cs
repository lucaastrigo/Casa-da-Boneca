using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abajur : MonoBehaviour
{
    public GameObject Xadez;

    bool foi;
    float shakeTime;
    Vector3 accelerationInput;

    void Update()
    {
        accelerationInput = Input.acceleration;

        if (!foi)
        {
            if (accelerationInput.sqrMagnitude >= 5f || Input.GetKey(KeyCode.O))
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
