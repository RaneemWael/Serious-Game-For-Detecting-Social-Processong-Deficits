using UnityEngine;
using System.Collections;

public class GridRotationScript : MonoBehaviour 
{
	public float DegreesToRotate;

	void Start () 
	{
		
	}

	void Update () 
	{
	
	}

	public void RotateGrid()
	{
		if (DegreesToRotate == 90.0f) 
		{
			transform.Rotate (Vector3.forward);
			if (transform.eulerAngles.z < DegreesToRotate) 
			{				
				Invoke ("RotateGrid", 0.0001f);
			}
		}
		else if(DegreesToRotate == 180.0f)
		{
			transform.Rotate (Vector3.forward);
			if (transform.eulerAngles.z < DegreesToRotate) 
			{				
				Invoke ("RotateGrid", 0.0001f);
			}
		}
		else if(DegreesToRotate == 270.0f)
		{
			transform.Rotate (Vector3.back);
			if (transform.eulerAngles.z > DegreesToRotate) 
			{				
				Invoke ("RotateGrid", 0.0001f);
			}
		}
	}
}
