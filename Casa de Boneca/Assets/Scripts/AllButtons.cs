using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllButtons : MonoBehaviour
{
    public Button SetaSala;
    public Button SetaQuarto;
    public Button SetaCozinha;
    public Button SetaBanheiro;

    public Button SetaCimaEsquerda;
    public Button SetaCimaDireita;
    public Button SetaCimaBaixo;
    
    public Button SetaBaixoEsquerda;
    public Button SetaBaixoDireita;
    public Button SetaBaixoCima;

    public Animator anim;

    Button MainButton;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetaSala_Main()
    {
        MainButton = SetaSala;
        StartCoroutine(Wait());
    }  
    public void SetaQuarto_Main()
    {
        MainButton = SetaQuarto;
        StartCoroutine(Wait());
    }    
    public void SetaCozinha_Main()
    {
        MainButton = SetaCozinha;
        StartCoroutine(Wait());
    }    
    public void SetaBanheiro_Main()
    {
        MainButton = SetaBanheiro;
        StartCoroutine(Wait());
    }   
    public void SetaCimaEsquerda_Main()
    {
        MainButton = SetaCimaEsquerda;
        StartCoroutine(Wait());
    }   
    public void SetaCimaDireita_Main()
    {
        MainButton = SetaCimaDireita;
        StartCoroutine(Wait());
    }   
    public void SetaCimaBaixo_Main()
    {
        MainButton = SetaCimaBaixo;
        StartCoroutine(Wait());
    }   
    public void SetaBaixoEsquerda_Main()
    {
        MainButton = SetaBaixoEsquerda;
        StartCoroutine(Wait());
    }   
    public void SetaBaixoDireita_Main()
    {
        MainButton = SetaBaixoDireita;
        StartCoroutine(Wait());
    }   
    public void SetaBaixoCima_Main()
    {
        MainButton = SetaBaixoCima;
        StartCoroutine(Wait());
    }



    public IEnumerator Wait()
    {
        anim.SetTrigger("Fade");
        yield return new WaitForSeconds(0.8f);    
        MainButton.onClick.Invoke();
    }
}
