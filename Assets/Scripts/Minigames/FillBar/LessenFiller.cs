using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessenFiller : MonoBehaviour
{
	Slider Fill;

	void Start()
    {
        InvokeRepeating("Sub", 0.0f, 0.1f);
    }

	public void Sub()
	{
		Fill = GetComponent<Slider>();
		if (!(Fill.value - 0.1f < 0.0f))
		{
			Fill.value -= 0.1f;
		}
	}
}
