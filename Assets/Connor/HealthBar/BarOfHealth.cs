using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarOfHealth : MonoBehaviour
{

	public Slider slider;
	public Image fill;
	public int health;

	public void SetMaxHealth()
	{
		slider.maxValue = health;
		slider.value = health;
		

	}

	public void SetHealth()
	{
		slider.value = health;
	}



    private void Update()
    {
		SetHealth();


	}
}