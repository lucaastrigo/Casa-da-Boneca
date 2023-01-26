using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float shakeMag;
    Vector3 accelerationInput;
    Vector3 originalPosition;

    void Update()
    {
        accelerationInput = Input.acceleration;

        if (accelerationInput.sqrMagnitude >= 5f)
        {
            ShakeCamera();

            Handheld.Vibrate();
        }
    }

    void ShakeCamera()
    {
        originalPosition = Camera.main.transform.position;
        InvokeRepeating("StartShake", 0f, 0.005f);
        Invoke("StopShake", 0.01f);
    }

    void StartShake()
    {
        float shakeOffsetX = Random.value * shakeMag * 2 - shakeMag;
        float shakeOffsetY = Random.value * shakeMag * 2 - shakeMag;
        Vector3 newCamera = Camera.main.transform.position;
        newCamera.x += shakeOffsetX;
        newCamera.y += shakeOffsetY;
        Camera.main.transform.position = newCamera;
    }

    void StopShake()
    {
        CancelInvoke("StartShake");
        Camera.main.transform.position = originalPosition;
    }
}
