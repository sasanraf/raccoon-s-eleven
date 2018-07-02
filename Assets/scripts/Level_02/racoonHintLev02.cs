using UnityEngine;
using System.Collections;

public class racoonHintLev02 : MonoBehaviour 
{
	GameObject timerGUIText;
	Camera camera;
	GameObject hintLevel02;
	// Use this for initialization
	void Start () 
	{
		timerGUIText = GameObject.Find ("timerGUIText");
		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		hintLevel02 = GameObject.Find ("hintLevel02");
	}
	
	
	void OnMouseDown()
	{
		audio.Play ();
		Time.timeScale=0;
		timerGUIText.guiText.enabled = false;
		camera.cullingMask = ~(1 << 11);
		hintLevel02.renderer.enabled = true;
		hintLevel02.collider2D.enabled = true;
	}
}
