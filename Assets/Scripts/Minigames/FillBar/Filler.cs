using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filler : MonoBehaviour
{
	Slider Fill;
	public GameObject barWhole;
	public GameObject btn;
	public GameObject congrats;

	public void Add(float num)
	{
		Fill = GetComponent<Slider>();
		Fill.value += num;
		if (Fill.value == 1.0f)
		{
			Fill.value = 0.0f;
			barWhole.SetActive(false);
			congrats.SetActive(true);
			btn.SetActive(false);
		}
	}

}
