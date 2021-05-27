using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AtivarDesativar : MonoBehaviour
{
    public GameObject[] ativar;
    public GameObject[] desativar;

    Collider2D coll;
    void Start()
    {
        coll = GetComponent<Collider2D>();
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
        }
    }
}
