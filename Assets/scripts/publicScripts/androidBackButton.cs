using UnityEngine;
using System.Collections;

public class androidBackButton : MonoBehaviour {

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			Application.Quit();
		}
	}
}
