using UnityEngine;
using System.Collections;

public class refreshGame_level09 : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("teamHiringLev09");
	}
	
	public void moveRefresh(bool TorF)
	{
		this.collider2D.enabled = TorF;
	}
}
