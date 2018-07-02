using UnityEngine;
using System.Collections;

public class hintLevel02 : MonoBehaviour 
{

	GameObject timerGUIText;
	Camera camera;
	// Use this for initialization
	void Start () 
	{
		timerGUIText = GameObject.Find ("timerGUIText");
		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		if (PlayerPrefs.GetInt("hintLevel02") == 1)
		{
			this.renderer.enabled = false;
			this.collider2D.enabled = false;
		}
		else
		{
			timerGUIText.guiText.enabled = false;
			camera.cullingMask = ~(1 << 11);
			this.renderer.enabled = true;
			PlayerPrefs.SetInt("hintLevel02",1);
			Time.timeScale=0;
		}

	}
	
	void OnMouseDown()
	{
		audio.Play ();
		Time.timeScale=1;
		timerGUIText.guiText.enabled = true;
		this.renderer.enabled = false;
		this.collider2D.enabled = false;
		Camera.main.cullingMask = ~(0);
	}
}
