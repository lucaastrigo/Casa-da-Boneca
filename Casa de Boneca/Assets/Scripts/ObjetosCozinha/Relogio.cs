﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class Relogio : MonoBehaviour
{
    public float speed = 5f;

    public bool stopMoving;
    public bool isMoving;
    public bool correto;
    public bool ponteiroMaior;
    public bool ponteiroMenorzinho;

    public static int numCertoMaior;
    public static int numCertoMenorzinho;

    public GameObject Codigo;

    public UnityEvent uEvent;

    Collider2D coll;
    AudioSource audSrc;

    void Start()
    {
        coll = GetComponent<Collider2D>();
        if (GetComponent<AudioSource>() != null) audSrc = GetComponent<AudioSource>();
    }

    void Update()
    { 
        if (!stopMoving)
        {

            if(numCertoMaior == 1 && numCertoMenorzinho == 1)
            {
                stopMoving = true;
                Codigo.SetActive(true);
                uEvent.Invoke();
                print("cabo");
            }
            if (Input.touchCount > 0)
            {

                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                if (touch.phase == TouchPhase.Began)
                {
                    Collider2D touchCollider = Physics2D.OverlapPoint(touchPosition);

                    if (coll == touchCollider)
                    {
                        isMoving = true;
                        //som de ponteiro fica ON
                        if (audSrc != null) audSrc.volume = 0.7f;
                    }
                }
                if (touch.phase == TouchPhase.Moved)
                {
                    if (isMoving)
                    {
                        float angle = Mathf.Atan2(touchPosition.y, touchPosition.x) * Mathf.Rad2Deg;
                        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
                        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
                    }
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    isMoving = false;
                    //som de ponteiro fica OFF
                    if(audSrc != null) audSrc.volume = 0;

                    if (correto)
                    {
                        if (ponteiroMaior) numCertoMaior = 1;
                        if (ponteiroMenorzinho) numCertoMenorzinho = 1;
                    }
                    else
                    {
                        if (ponteiroMaior) numCertoMaior = 0;
                        if (ponteiroMenorzinho) numCertoMenorzinho = 0;
                    }
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("DireitaTag") && ponteiroMaior)
        {
            correto = true;

        }
        if (other.gameObject.CompareTag("EsquerdaTag") && ponteiroMenorzinho)
        {
            correto = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DireitaTag") && ponteiroMaior)
        {
            correto = false;

        }
        if (other.gameObject.CompareTag("EsquerdaTag") && ponteiroMenorzinho)
        {
            correto = false;
        }
    }

}
