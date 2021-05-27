using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeLock : MonoBehaviour
{
    public GameObject vitrine;
    public GameObject codelock;

    public bool canCode;
    public string codigo;

    string word = null;
    int wordIndex = 0;
    string reset;

    public Text nameCode = null;
    public Text index = null;

    public SoundManager sm;
    public AudioClip acerto;
    public AudioClip erro;

    void Start()
    {
        canCode = true;
    }
    public void CodeString(string letras)
    {
        if (canCode  && wordIndex < 6)
        {
            wordIndex++;
            word = word + letras;
            nameCode.text = word;
        }

    }

    public void DeleteString()
    {
        if (canCode)
        {
            if (wordIndex >= 0)
            {
                wordIndex = 0;
                word = reset;
                nameCode.text = word;
            }
        }
    }

    public void CompleteString()
    {
        if (word == codigo)
        {
            canCode = false;
            nameCode.color = Color.green;
            Globals.codelockAberto = true;
            vitrine.SetActive(true);
            codelock.SetActive(false);
            sm.AudioCodeCerto();
        }
        else
        {
            sm.AudioCodeErrado();
        }
    }
}
