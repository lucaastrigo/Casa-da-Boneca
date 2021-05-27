using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class indLivro : MonoBehaviour
{
    public bool livroTouch;
    public bool vamoBruno;
    public static int touches;

    public float posCerta;
    public float posOffset;
    void Start()
    {
        
    }

    void Update()
    {
        if (gameObject.GetComponent<RectTransform>().position.x > posCerta - posOffset && gameObject.GetComponent<RectTransform>().position.x < posCerta + posOffset)
        {
            GetComponent<Button>().enabled = false;
            vamoBruno = true;
        }

        if(touches == 0)
        {
            gameObject.GetComponent<Image>().color = Color.white;
            livroTouch = false;
        }
    }

    public void Primeiro()
    {
        if (Livros.click)
        {
            gameObject.GetComponent<Image>().color = Color.gray;
            livroTouch = true;
            touches++;
        }
    }
}
