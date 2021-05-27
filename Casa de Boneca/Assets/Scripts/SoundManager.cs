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
        audioManager.PlayOneShot(agua, 0.6f);
    }
}
