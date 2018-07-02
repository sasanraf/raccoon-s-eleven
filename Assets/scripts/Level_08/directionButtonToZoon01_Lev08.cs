using UnityEngine;
using System.Collections;

public class directionButtonToZoon01_Lev08 : MonoBehaviour {
	
	private cameraZoonChange camera;
	GameObject highlightDirectionRight;


	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange>();
		highlightDirectionRight = GameObject.Find ("highlightDirectionRight");

	}
	
	void OnMouseDown()
	{
		if (highlightDirectionRight)
		{
			Destroy (highlightDirectionRight);
		}

		camera.movetoZoon1();
	}
}