using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XadrezGlobal : MonoBehaviour
{
    public static int xadrezQuant;
    public bool botao;

    Collider2D coll;
    void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (!botao)
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
                        gameObject.SetActive(false);
                        xadrezQuant++;
                        gameObject.GetComponent<SpriteRenderer>().enabled = false;
                        coll.enabled = false;
                    }
                }
            }
        }

        if(xadrezQuant >= 4)
        {
            Globals.tabuleiroAberto = true;
          
        }
    }

    public void XadrezAumenta()
    {
        gameObject.SetActive(false);
        xadrezQuant++;
        Destroy(gameObject);
    }
}
