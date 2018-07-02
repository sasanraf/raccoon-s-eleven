using UnityEngine;
using System.Collections;

public class hintPreviewLevel07 : MonoBehaviour 
{	
	GameObject raccoonHint;
	void Start () 
	{
		raccoonHint = GameObject.Find ("raccoonHint");
		if (PlayerPrefs.GetInt("hintPreviewLevel07") == 1)
		{
			this.renderer.enabled = false;
			this.collider2D.enabled = false;
			Destroy(raccoonHint);
		}
		else
		{
			this.renderer.enabled = true;
			PlayerPrefs.SetInt("hintPreviewLevel07",1);
			raccoonHint.renderer.enabled = true;
		}
	}

	void OnMouseDown()
	{
		audio.Play ();
		this.renderer.enabled = false;
		this.collider2D.enabled = false;
		Destroy(raccoonHint);
	}
}
