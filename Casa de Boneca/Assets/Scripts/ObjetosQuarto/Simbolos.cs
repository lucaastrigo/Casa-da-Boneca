using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simbolos : MonoBehaviour
{

    public int ordemClicks;
    public static int ordemCerta;

    public static bool canClick;
    public static bool errado;

    public GameObject armario;
    public SoundManager sm;

    SpriteRenderer sprite;
    Collider2D coll;
    void Start()
    {
        coll = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
        ordemCerta = 1;
        canClick = true;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {

                Collider2D touchCollider = Physics2D.OverlapPoint(touchPosition);

                if (coll == touchCollider)
                {
                    if (canClick)
                    {
                        if (ordemCerta == ordemClicks)
                        {
                            ordemCerta++;
                            sprite.enabled = true;
                            sm.AudioRuna();
                        }
                        else
                        {
                            errado = true;
                        }
                    }

                }
                if (!coll == touchCollider)
                {
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
            }

            if (touch.phase == TouchPhase.Ended)
            {
            }
        }

        if(errado)
        {
            sprite.enabled = true;
            ordemCerta = 1;
            canClick = false;
            StartCoroutine(Wrong());
        }
        if (ordemCerta > 6)
        {
            print("Cabo");
            canClick = false;
            coll.enabled = false;
            Globals.armarioAberto = true;
            armario.SetActive(true);
        }

    }

    IEnumerator Wrong()
    {
        yield return new WaitForSeconds(0.5f);
        sprite.enabled = false;
        errado = false;
        canClick = true;
    }
}
