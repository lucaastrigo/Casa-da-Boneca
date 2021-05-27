using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptorGlobal : MonoBehaviour
{
    public Sprite Ligado;
    public SoundManager sm;
    Collider2D coll;

    public string name;

    public static bool numBanheiro;
    public static bool numCozinha;
    public static bool numSalaDeEstar;
    public static bool numQuarto;
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    void Update()
    {

        if(numBanheiro && numCozinha && numSalaDeEstar && numQuarto)
        {
            Globals.interruptoresLigados = true;
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
                    //Setar Trigger 
                    gameObject.GetComponent<SpriteRenderer>().sprite = Ligado;
                    sm.AudioInterruptor();
                    coll.enabled = false;

                    if(name == "Banheiro")
                    {
                        numBanheiro = true;
                    }
                    if (name == "Cozinha")
                    {
                        numCozinha = true;
                    }
                    if (name == "SalaDeEstar")
                    {
                        numSalaDeEstar = true;
                    }
                    if (name == "Quarto")
                    {
                        numQuarto = true;
                    }


                }
            }
        }
    }
}
