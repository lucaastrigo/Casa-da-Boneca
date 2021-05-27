using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Cadeado : MonoBehaviour
{
    public GameObject geladeira;
    public GameObject cadeado;

    public TMP_Text textNum1;
    public TMP_Text textNum2;
    public TMP_Text textNum3;

    public int correctNum1;
    public int correctNum2;
    public int correctNum3;

    private bool canMove;

    private int num1;
    private int num2;
    private int num3;

    void Start()
    {
        canMove = true;
    }

    void Update()
    {
        textNum1.text = num1.ToString();
        textNum2.text = num2.ToString();
        textNum3.text = num3.ToString();

        if(num1 == correctNum1 && num2 == correctNum2 && num3 == correctNum3)
        {
            canMove = false;
            geladeira.SetActive(true);
            cadeado.SetActive(false);

            textNum1.color = new Color(0.5f, 1f, 0.5f);
            textNum2.color = new Color(0.5f, 1f, 0.5f);
            textNum3.color = new Color(0.5f, 1f, 0.5f);
        }
    }

    public void AddNum1()
    {
        if (canMove)
        {
            num1++;
            if (num1 > 9) num1 = 0;
        }
    }
    public void AddNum2()
    {
        if (canMove)
        {
            num2++;
            if (num2 > 9) num2 = 0;
        }
    }
    public void AddNum3()
    {
        if (canMove)
        {
            num3++;
            if (num3 > 9) num3 = 0;
        }
    }

    public void SubtractNum1()
    {
        if (canMove)
        {
            num1--;
            if (num1 < 0) num1 = 9;
        }
    }
    public void SubtractNum2()
    {
        if (canMove)
        {
            num2--;
            if (num2 < 0) num2 = 9;
        }
    }
    public void SubtractNum3()
    {
        if (canMove)
        {
            num3--;
            if (num3 < 0) num3 = 9;
        }
    }
}
