using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Livros : MonoBehaviour
{
    public GameObject[] livros;
    public GameObject livrinho1;
    public GameObject livrinho2;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject trigoBacaca;

    public Transform[] pos;
    public bool[] ArrayCerto;

    private int touching;
    public static bool click;
    public static int livrosCertos;
    
    void Start()
    {
        click = true;
    }

    void Update()
    {
        for (int i = 0; i < livros.Length; i++)
        {          
            if(livros[i].GetComponent<indLivro>().livroTouch)
            {
                if (indLivro.touches == 1)
                {
                    livrinho1 = livros[i];
                    pos1.transform.position = livrinho1.transform.position;
                }
                if (indLivro.touches == 2)
                {
                    livrinho2 = livros[i];
                    pos2.transform.position = livrinho2.transform.position;
                    click = false;
                    StartCoroutine(otario());
                }
                
            }  
            if(livros[i].GetComponent<indLivro>().vamoBruno)
            {
                ArrayCerto[i] = true;
            }
            else
            {
                ArrayCerto[i] = false;
            }
        }

        if (ArrayCerto.All(b => b))
        {
            trigoBacaca.SetActive(true);
        }


    }


    void PrimeiroToque()
    {
        //GameObject troca1;
    }

    IEnumerator otario()
    {
        
        yield return new WaitForSeconds(0.5f);
        livrinho1.transform.position = pos2.transform.position;
        livrinho2.transform.position = pos1.transform.position;
        indLivro.touches = 0;
        yield return new WaitForSeconds(0.5f);
        click = true;

    }

}
