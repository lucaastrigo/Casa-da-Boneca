using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    public SoundManager sm; 
    Collider2D coll;



    public GameObject banheiro;
    public GameObject cozinha;
    public GameObject salaDeEstar;
    public GameObject quarto;

    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
   

        if (InterruptorGlobal.numBanheiro)
        {
            banheiro.SetActive(true);
        }
        if (InterruptorGlobal.numCozinha)
        {
            cozinha.SetActive(true);
        }
        if (InterruptorGlobal.numQuarto)
        {
            quarto.SetActive(true);
        }
        if (InterruptorGlobal.numSalaDeEstar)
        {
            salaDeEstar.SetActive(true);
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

                    if (InterruptorGlobal.numBanheiro && InterruptorGlobal.numCozinha && InterruptorGlobal.numQuarto && InterruptorGlobal.numSalaDeEstar)
                    {
                        StartCoroutine(Zeraste());
                    }

                }
            }
        }
    }

    IEnumerator Zeraste()
    {
        sm.AudioVitoria();
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("Vitoria");
    }
}
