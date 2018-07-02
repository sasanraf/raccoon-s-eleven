using UnityEngine;
using System.Collections;

public class directionBtnZoon24 : MonoBehaviour {

	private cameraZoonChange_level10 camera;

	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange_level10>();
	}
	
	void OnMouseDown()
	{

		camera.movetoZoon24();
	}
}

