using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");

    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void CreditScene()
    {
        SceneManager.LoadScene("CreditScene");

    }

    public void HelpScene()
    {
        SceneManager.LoadScene("Help");

    }

    public void Backtomenu()
    {
        SceneManager.LoadScene("Menu_Place");

    }


}


