using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtoogame : MonoBehaviour
{
    public void Goback()
    {
        SceneManager.LoadScene("Menu_Place");

    }
}