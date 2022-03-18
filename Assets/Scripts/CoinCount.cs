using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
	public int count = 0;
	Text text;

	public int getCount()
    {
		return count;
    }

	public void Add(int num)
	{
		count += num;
		text = GetComponent<Text>();
		text.text = "Coins: " + count;
	}

	public void Sub(int num)
	{
		count -= num;
		text = GetComponent<Text>();
		text.text = "Coins: " + count;
	}
}
