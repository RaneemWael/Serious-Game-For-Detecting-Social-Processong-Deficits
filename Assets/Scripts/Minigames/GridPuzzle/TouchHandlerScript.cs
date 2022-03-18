using UnityEngine;
using System.Collections;

public class TouchHandlerScript : MonoBehaviour 
{
	[SerializeField]
	int Row;
	[SerializeField]
	int Column;

	public bool IsClicked;
	public GameObject GameManager;
	CheckForMatchScript CMS;

	void Start () 
	{
		GameManager = GameObject.FindGameObjectWithTag ("GM");
		CMS = GameManager.GetComponent<CheckForMatchScript> ();
	}

	void OnMouseDown()
	{
		gameObject.GetComponent<AudioSource>().Play();
		if (!IsClicked) 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (117, 94, 210, 255);
			CMS.SetGridValue (Row, Column, 1);
		} 
		else 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color32 (132, 203, 252, 255);
			CMS.SetGridValue (Row, Column, 2);
		}
		IsClicked = !IsClicked;
	}
}
