using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    public int rightPlace;
    public Bookcase bookcase;

    [HideInInspector] public bool selected;

    public void SelectBook()
    {
        if (!bookcase.finished)
        {
            if (!selected)
            {
                selected = true;

                if (bookcase.selectedBooks < 2)
                {
                    ++bookcase.selectedBooks;

                    if (bookcase.selectedBooks == 1)
                    {
                        bookcase.book1 = gameObject;
                        bookcase.pos1 = transform;
                    }
                    else if (bookcase.selectedBooks == 2)
                    {
                        bookcase.book2 = gameObject;
                        bookcase.pos2 = transform;

                        bookcase.SwapBooks();
                    }
                }
            }
            else
            {
                bookcase.ClearSwap();
            }
        }
    }
}
