using UnityEngine;
using System.Collections;

public class CCTV_view : MonoBehaviour {

	Camera camera;

	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		camera.cullingMask = ~(1 << 11);
		Time.timeScale=0;
	}
	
	void OnMouseDown()
	{
		Time.timeScale=1;
		Camera.main.cullingMask = ~(0);
		Destroy (gameObject);
	}
}
