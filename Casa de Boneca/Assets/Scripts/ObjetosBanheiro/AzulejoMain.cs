using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AzulejoMain : MonoBehaviour
{
    public GameObject espelho;

    public GameObject[] azulejos;
    public bool[] vetorCerto;

    void Update()
    {
        for (int i = 0; i < azulejos.Length; i++)
        {
            if (!azulejos[i].GetComponent<Azulejo>().can)
            {
                vetorCerto[i] = true;
            }
            else
            {
                vetorCerto[i] = false;
            }
        }

        if (vetorCerto.All(b => b))
        {
            Azulejo.canRotate = false;
            espelho.SetActive(true);
        }
    }
}
