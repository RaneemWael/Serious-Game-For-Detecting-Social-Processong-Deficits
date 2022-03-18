using UnityEngine;
using System.Collections;

public class CheckForMatchScript : MonoBehaviour 
{
	public GameObject text;
	public GameObject game;
	public GameObject chestClose;
	public GameObject chestOpen;

	private bool blue = false;
	private bool purple = false;
	int[,] Grid = new int[3, 3];
	
	void Start () 
	{
	}

	public void SetGridValue(int Row, int Column, int State)
	{
		Grid[Row, Column] = State;
		CheckForMatch();
	}

	void CheckForMatch ()
	{
		if ((Grid[0, 0] == 1) && (Grid[1, 1] == 1) && (Grid[2, 1] == 1) && (Grid[2, 2] == 1))
		{
			purple = true;
		}
		if ((Grid[0, 1] == 2) && (Grid[1, 0] == 2) && (Grid[1, 2] == 2) && (Grid[2, 0] == 2))
		{
			blue = true;
		}
		if (blue && purple)
        {
			game.SetActive(false);
			text.SetActive(true);
			chestClose.SetActive(false);
			chestOpen.SetActive(true);
		}
	}
}
