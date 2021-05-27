using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float deathTime; //vida atual
    public float shakeMag;
    public GameObject healthBar;

    float timer; //maximo de vida
    Vector3 accelerationInput;
    Vector3 originalPosition;

    private void Start()
    {
        timer = deathTime;


        healthBar.GetComponent<HealthHUD>().SetMaxHealth(timer);
    }

    void Update()
    {
        accelerationInput = Input.acceleration;
        healthBar.GetComponent<HealthHUD>().SetHealth(deathTime);

        if (accelerationInput.sqrMagnitude >= 5f)
        {
            ShakeCamera();

            Handheld.Vibrate();

            deathTime -= Time.deltaTime * 1.5f;

            if(deathTime <= 0)
            {
                SceneManager.LoadScene("Derrota");
            }
        }
        else
        {
            deathTime += Time.deltaTime / 5;

            if(deathTime >= timer)
            {
                deathTime = timer;
            }
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
