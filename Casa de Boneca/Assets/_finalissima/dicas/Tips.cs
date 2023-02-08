using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System.Linq;

public class Tips : MonoBehaviour
{
    public RectTransform contentSize;
    public List<GameObject> tipSlots = new List<GameObject>();
    public List<Image> tipImages = new List<Image>();
    public List<Sprite> tipSprites = new List<Sprite>();

    public GameObject bigTipPanel;
    public Image bigTipImage;

    private void Start()
    {
        for (int i = 0; i < tipSlots.Count; i++)
        {
            tipSlots[i].SetActive(false);
        }
    }

    void Update()
    {
        for (int i = 0; i < tipSlots.Count; i++)
        {
            if (!tipSlots[i].activeSelf)
            {
                float x = contentSize.sizeDelta.x;
                contentSize.sizeDelta = new Vector2(x, 140 * i);
                break;
            }
            else
            {
                float x = contentSize.sizeDelta.x;
                contentSize.sizeDelta = new Vector2(x, 140 * 13);
            }
        }
    }

    public void NewTip(Sprite tipSprite)
    {
        for (int i = 0; i < tipSlots.Count; i++)
        {
            if (!tipSlots[i].activeSelf && !tipSprites.Contains(tipSprite))
            {
                tipSlots[i].SetActive(true);
                tipImages[i].sprite = tipSprite;
                tipSprites.Add(tipSprite);
                break;
            }

            //if (tipImages[i].sprite != tipSprite && !tipSlots[i].activeSelf)
            //{
            //    tipSlots[i].SetActive(true);
            //    tipImages[i].sprite = tipSprite;
            //    break;
            //}

            //if (!tipSlots[i].activeSelf)
            //{
            //    tipSlots[i].SetActive(true);
            //    tipImages[i].sprite = tipSprite;
            //    break;
            //}
        }
    }

    public void ActivateBigTip()
    {
        if (!bigTipPanel.activeSelf) bigTipPanel.SetActive(true);
    }

    public void SetTipImage(Image tipI)
    {
        bigTipImage.sprite = tipI.sprite;
    }
}
