using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public string scene;

    public void StartGameplayMuitoLoca()
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitSuperGameplayShowDeBola()
    {
        Application.Quit();
    }
}
