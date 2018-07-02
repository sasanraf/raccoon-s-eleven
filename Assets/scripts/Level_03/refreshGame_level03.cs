using UnityEngine;
using System.Collections;

public class refreshGame_level03 : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("teamHiringLev03");
	}
	
	public void moveRefresh(bool TorF)
	{
		this.collider2D.enabled = TorF;
	}
}
