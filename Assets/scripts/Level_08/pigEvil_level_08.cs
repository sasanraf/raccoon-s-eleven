using UnityEngine;
using System.Collections;

public class pigEvil_level_08 : MonoBehaviour 
{
		
	Camera camera;
	string currentLevelName;
	bool audioPlayed = false;
	
	public AudioSource laughing;
	public AudioSource moneyback;

	dog_Level_08 dog;
	
	
	void Start () 
	{

		dog = GameObject.Find ("dog").GetComponent<dog_Level_08>();
		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		currentLevelName = Application.loadedLevelName;	
		
		AudioSource[] audios = GetComponents<AudioSource>();
		laughing = audios[0];
		moneyback = audios[1];
	}
	
	public void pigLaughing () 
	{

		if(!audio.isPlaying && audioPlayed == false)
		{
			this.laughing.Play();
			this.moneyback.Play();
			audioPlayed = true;
		}
		

		
		//text layer is 11
		camera.cullingMask = ~(1 << 11);
		renderer.enabled = true;
		collider2D.enabled = true;
	}
	
	void OnMouseDown()
	{
		Camera.main.cullingMask = ~(0);
		if (dog.dogArrestedCheck != true)
		{
			Application.LoadLevel(currentLevelName);
		}
		else
		{
			Application.LoadLevel("teamHiringLev08");
		}
	}
	

}
