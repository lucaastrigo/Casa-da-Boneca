using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azulejo : MonoBehaviour
{
    public int pos;
    public static bool canRotate = true;
    public bool can = true;
    public AudioSource audioManager;
    public AudioClip azulejoGirando;
    public Animator anim;

    public int correctNumber;

    int correct = 1;
    Collider2D coll;

    void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (canRotate)
        {
            if (correct > 4)
            {
                correct = 1;
            }

            if (pos == correctNumber)
            {
                if (can)
                {
                    can = false;
                }
            }
            else
            {
                can = true;
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

                        audioManager.PlayOneShot(azulejoGirando, 0.6f);
                        correct++;
                        pos++;
                        if (pos == 1)
                        {
                            //esquerda
                            anim.SetTrigger("Esquerda");
                        }
                        else if (pos == 2)
                        {
                            //baixo
                            anim.SetTrigger("Baixo");
                        }
                        else if (pos == 3)
                        {
                            //direita
                            anim.SetTrigger("Direita");
                        }
                        else if (pos == 4)
                        {
                            //cima
                            anim.SetTrigger("Cima");
                        }
                        else if (pos > 4)
                        {
                            anim.SetTrigger("Esquerda");
                            pos = 1;
                        }
                        
                    }
                }
            }
        }
    }
}
