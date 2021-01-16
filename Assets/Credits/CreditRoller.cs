using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRoller : MonoBehaviour
{
    private static int nScreens = 6;
    private GameObject[] creditScreens = new GameObject[nScreens];
    private static int swapCount = 0;


    // Use this for initialization
    void Start()
    {
        //For each credit screen, add a new reference here:
        creditScreens[0] = GameObject.Find("credit1");
        creditScreens[1] = GameObject.Find("credit2");
        creditScreens[2] = GameObject.Find("credit3");
        creditScreens[3] = GameObject.Find("credit4");
        creditScreens[4] = GameObject.Find("credit5");
        creditScreens[5] = GameObject.Find("credit6");


        //Turn them all off...
        for (int i = 0; i < nScreens; i++)
        {
            creditScreens[i].SetActive(false);
        }
        //Except, turn back on element 0
        creditScreens[0].SetActive(true);
    } //Start


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            //Toggle
            int currentScene = swapCount % nScreens;
            creditScreens[currentScene].SetActive(false);
            swapCount++;
            currentScene = swapCount % nScreens;
            creditScreens[currentScene].SetActive(true);


        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    } ////Update

}

