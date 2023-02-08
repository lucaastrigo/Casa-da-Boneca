using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioManager;
    public AudioClip EscadaBaixo;
    public AudioClip EscadaCima;
    public AudioClip EscadaLado;
    public AudioClip armarioLocked;
    public AudioClip gameover;
    public AudioClip codelockTecla;
    public AudioClip codelockCerto;
    public AudioClip codelockErrado;
    public AudioClip shake;
    public AudioClip geladeiraOpen;
    public AudioClip interruptores;
    public AudioClip win;
    public AudioClip runa;
    public AudioClip agua;

    public AudioClip uiPuxa;
    public AudioClip uiButtons;
    public AudioClip porta;
    public AudioClip xadrezBanheira;
    public AudioClip[] valvulas;
    public AudioClip cadeadoCozinha;
    public AudioClip botaoCadeado;
    public AudioClip xadrezAbajur;
    public AudioClip runasCertas;
    public AudioClip trocaLivro;
    public AudioClip resetCofre;
    public AudioClip tvCanalCerto;
    public AudioClip tvBotao;
    public AudioClip tvChiado;
    public AudioClip tvSintonizado;

    public void AudioEscadaBaixo()
    {
        audioManager.PlayOneShot(EscadaBaixo, 1);
    }
    public void AudioEscadaCima()
    {
        audioManager.PlayOneShot(EscadaCima, 0.6f);
    }
    public void AudioEscadaLado()
    {
        audioManager.PlayOneShot(EscadaLado, 0.6f);
    }

    public void AudioArmario()
    {
        audioManager.PlayOneShot(armarioLocked, 0.6f);
    }

    public void AudioGameOver()
    {
        audioManager.PlayOneShot(gameover, 0.6f);
    }

    public void AudioCodeCerto()
    {
        audioManager.PlayOneShot(codelockCerto, 0.6f);
    }

    public void AudioCodeErrado()
    {
        audioManager.PlayOneShot(codelockErrado, 0.6f);
    }

    public void AudioCodeTecla()
    {
        audioManager.PlayOneShot(codelockTecla, 0.6f);
    }

    public void AudioShake()
    {
        audioManager.PlayOneShot(shake, 0.6f);
    }

    public void AudioInterruptor()
    {
        audioManager.PlayOneShot(interruptores, 0.6f);
    }

    public void AudioVitoria()
    {
        audioManager.PlayOneShot(win, 0.6f);
    }

    public void AudioRuna()
    {
        audioManager.PlayOneShot(runa, 0.6f);
    }

    public void AudioAgua()
    {
        audioManager.PlayOneShot(agua, 0.85f);
    }

    public void AudioPuxaUI()
    {
        audioManager.PlayOneShot(uiPuxa, 0.45f);
    }

    public void AudioUIButtons()
    {
        audioManager.PlayOneShot(uiButtons, 0.8f);
    }

    public void AudioPorta()
    {
        audioManager.PlayOneShot(porta, 0.5f);
    }

    public void AudioXadrezBanheira()
    {
        audioManager.PlayOneShot(xadrezBanheira, 0.6f);
    }

    public void AudioValvula()
    {
        audioManager.PlayOneShot(valvulas[Random.Range(0, valvulas.Length)], 0.3f);
    }

    public void AudioCadeadoCozinha()
    {
        audioManager.PlayOneShot(cadeadoCozinha, 1);
    }

    public void AudioBotaoCadeado()
    {
        audioManager.PlayOneShot(botaoCadeado, 0.75f);
    }

    public void AudioXadrezAbajur()
    {
        audioManager.PlayOneShot(xadrezAbajur, 1);
    }

    public void AudioRunasCertas()
    {
        audioManager.PlayOneShot(runasCertas, 1);
    }

    public void AudioTrocaLivro()
    {
        audioManager.PlayOneShot(trocaLivro, 0.65f);
    }

    public void AudioResetCofre()
    {
        audioManager.PlayOneShot(resetCofre, 0.85f);
    }

    public void AudioTVCanalCerto()
    {
        audioManager.PlayOneShot(tvCanalCerto, 1);
    }

    public void AudioTVBotao()
    {
        audioManager.PlayOneShot(tvBotao, 0.65f);
    }
}
