using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Demo");

    }
    public void Quitgame()
    {
        Application.Quit();
    }
    
}


