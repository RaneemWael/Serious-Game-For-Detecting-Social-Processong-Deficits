using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour 
{
	public Filler bar;

	public void OnClickEnter () {
		bar.Add(0.3f);
	}
}
