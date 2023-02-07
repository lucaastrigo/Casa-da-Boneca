using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AtivarGlobais : MonoBehaviour
{
    public GameObject[] ativar;
    public GameObject[] desativar;

    public bool armario;
    public bool torneira;
    public bool tabuleiro;

    public GameObject xadrez;
    public UnityEvent torneiraEvent;

    Collider2D coll;
    void Start()
    {
        coll = GetComponent<Collider2D>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && torneira)
        {
            torneiraEvent.Invoke();
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
                    if (Globals.armarioAberto && armario) 
                    {
                        AtivarTudo();
                    }
                    else if(Globals.torneiraAberta && torneira)
                    {
                        AtivarTudo();
                        torneiraEvent.Invoke();
                    }   
                    else if(Globals.tabuleiroAberto && tabuleiro)
                    {
                        AtivarTudo();
                    }
                }
            }
        }

        if (Globals.tabuleiroAberto && tabuleiro)
        {
            xadrez.SetActive(true);
        }
    }

    void AtivarTudo()
    {
        foreach (GameObject atv in ativar)
        {
            atv.SetActive(true);
        }

        foreach (GameObject desatv in desativar)
        {
            desatv.SetActive(false);
        }
    }
}
