using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TV : MonoBehaviour
{
    public int intTudo;

    public Text TvNumber;
    public GameObject Xadez;
    
    public Sprite Original;
    public Sprite Azulejo;
    public Sprite Xadrez;

    private int intCentena;
    private int intDezena;
    private int intUnidade;

    void Start()
    {
        
    }

    void Update()
    {
        intTudo = intCentena + intDezena + intUnidade;
        TvNumber.text = intTudo.ToString();
        if (intTudo > 300)
        {
            intCentena = 0;
            intDezena = 0;
            intUnidade = 0;
        }
        if (intTudo < 100)
        {
            TvNumber.text = "0" + intTudo.ToString();
            if(intTudo < 10)
            {
                TvNumber.text = "00" + intTudo.ToString();
            }
        }

        if(intTudo == 178)
        {
            GetComponent<Image>().sprite = Azulejo;
        }
        else if(intTudo == 255)
        {
            GetComponent<Image>().sprite = Xadrez;
            Xadez.SetActive(true);

        }
        else
        {
            GetComponent<Image>().sprite = Original;
        }

    }


    public void Centena()
    {
        intCentena += 100;
    }

    public void Dezena()
    {
        intDezena += 10;
    }

    public void Unidade()
    {
        intUnidade += 1;
    }

}
