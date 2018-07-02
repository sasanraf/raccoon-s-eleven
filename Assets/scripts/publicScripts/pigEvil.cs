using UnityEngine;
using System.Collections;

public class pigEvil : MonoBehaviour {

	Camera camera;
	string currentLevelName;
	bool audioPlayed = false;

	public AudioSource laughing;
	public AudioSource moneyback;
	

	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		currentLevelName = Application.loadedLevelName;	

		AudioSource[] audios = GetComponents<AudioSource>();
		laughing = audios[0];
		moneyback = audios[1];
	}

	public void pigLaughing () 
	{
		//audio.Play() not working
		//http://stackoverflow.com/questions/20603052/audio-play-not-working
		//Given that you are calling it as part of your Update routine, I'd have to guess that the problem is you calling it repeatedly. I.e. you're calling it every frame as long as timer <= 0.
		//You shouldn't call Play() more than once. Or at least not again while it is playing. A simple fix would be something along the lines of
		if(!audio.isPlaying && audioPlayed == false)
		{
			this.laughing.Play();
			this.moneyback.Play();
			audioPlayed = true;
		}

		//Camera.main.cullingMask = ~(1 << 8);
		//And to reset it to render everything:
		//

		//text layer is 11
		camera.cullingMask = ~(1 << 11);
		renderer.enabled = true;
		collider2D.enabled = true;
	}

	void OnMouseDown()
	{
		Camera.main.cullingMask = ~(0);
		Application.LoadLevel(currentLevelName);
	}

}
