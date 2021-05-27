using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Valvula : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;

    public bool canRotate;
    public GameObject pia;
    public GameObject encanamento;

    public GameObject[] valvulas;
    public SoundManager agua;
    float vol;

    private void Start()
    {
        vol = 0;
    }

    void Update()
    {
        if(num1 == -6 && num2 == 12 && num3 == 12)
        {
            canRotate = false;
            Globals.torneiraAberta = true;
            pia.SetActive(true);
            encanamento.SetActive(false);
        }
    }
    public void RotacionaEsquerda()
    {
        if (canRotate)
        {
            if (num1 > -6)
            {
                valvulas[0].transform.Rotate(0, 0, 15);
                num1--;
            }

            if(num1 == -6)
            {
                agua.AudioAgua();
            }
        }
    }

    public void RotacionaDireita()
    {
        if (canRotate)
        {
            if (num1 < 12)
            {
                valvulas[0].transform.Rotate(0, 0, -15);
                num1++;
            }
        }
    }
    //222222222222222222222222222222
    public void RotacionaEsquerda2()
    {
        if (canRotate)
        {
            if (num2 > -6)
            {
                valvulas[1].transform.Rotate(0, 0, 15);
                num2--;
            }
        }
    }

    public void RotacionaDireita2()
    {
        if (canRotate)
        {
            if (num2 < 12)
            {
                valvulas[1].transform.Rotate(0, 0, -15);
                num2++;
            }

            if (num2 == 12)
            {
                agua.AudioAgua();
            }
        }
    }
    //222222222222222222222
    public void RotacionaEsquerda3()
    {
        if (canRotate)
        {
            if (num3 > -6)
            {
                valvulas[2].transform.Rotate(0, 0, 15);
                num3--;
            }
        }
    }

    public void RotacionaDireita3()
    {
        if (canRotate)
        {
            if (num3 < 12)
            {
                valvulas[2].transform.Rotate(0, 0, -15);
                num3++;
            }

            if (num3 == 12)
            {
                agua.AudioAgua();
            }
        }
    }

}
