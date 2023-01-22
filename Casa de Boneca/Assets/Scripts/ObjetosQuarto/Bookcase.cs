using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Bookcase : MonoBehaviour
{
    public List<Book> books = new List<Book>();
    public GameObject interrupter;

    [HideInInspector] public int selectedBooks;
    [HideInInspector] public int book1pos, book2pos;
    [HideInInspector] public bool finished;
    [HideInInspector] public GameObject book1, book2;
    [HideInInspector] public Transform pos1, pos2;

    public void SwapBooks()
    {
        Vector3 posi1 = pos1.position;
        Vector3 posi2 = pos2.position;

        book1.transform.position = posi2;
        book2.transform.position = posi1;

        for (int i = 0; i < books.Count; i++)
        {
            if (books[i] == book1.GetComponent<Book>())
            {
                book1pos = i;
            }
            else if (books[i] == book2.GetComponent<Book>())
            {
                book2pos = i;
            }
        }

        Swap(books, book1pos, book2pos);
        ClearSwap();
    }

    public void ClearSwap()
    {
        selectedBooks = 0;

        if (book1 != null && book1.GetComponent<Book>() != null)
        {
            book1.GetComponent<Book>().selected = false;
        }

        if (book2 != null && book2.GetComponent<Book>() != null)
        {
            book2.GetComponent<Book>().selected = false;
        }

        book1 = null;
        pos1 = null;
        book2 = null;
        pos2 = null;

        if (canFinishPuzzle())
        {
            FinishPuzzle();
        }
    }

    void FinishPuzzle()
    {
        finished = true;
        interrupter.SetActive(true);
    }

    bool canFinishPuzzle()
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (i != books[i].rightPlace)
            {
                return false;
            }
        }

        return true;
    }

    void Swap(List<Book> list, int indexA, int indexB)
    {
        Book tmp = list[indexA];

        list[indexA] = list[indexB];
        list[indexB] = tmp;
    }
}
