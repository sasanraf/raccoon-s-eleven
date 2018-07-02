using UnityEngine;
using System.Collections;

public class refreshGame : MonoBehaviour {

	string currentLevelName;
	Animator anim;

	void Start () {
		currentLevelName = Application.loadedLevelName;	
		anim = this.GetComponent<Animator>();
	}

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel(currentLevelName);
	}

	public void moveRefresh(bool TorF)
	{
		anim.SetBool("moveRefresh", TorF);
		this.collider2D.enabled = TorF;
	}

}





