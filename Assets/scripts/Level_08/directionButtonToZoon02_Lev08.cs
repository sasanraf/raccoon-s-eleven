using UnityEngine;
using System.Collections;

public class directionButtonToZoon02_Lev08 : MonoBehaviour {

	private cameraZoonChange camera;
	GameObject highlightDirectionLeft;


	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange>();
		highlightDirectionLeft = GameObject.Find ("highlightDirectionLeft");

	}
	
	void OnMouseDown()
	{
		if (highlightDirectionLeft)
		{
			Destroy (highlightDirectionLeft);
		}	
		
		camera.movetoZoon2();
	}
}


