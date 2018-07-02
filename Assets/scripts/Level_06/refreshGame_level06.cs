using UnityEngine;
using System.Collections;

public class refreshGame_level06 : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("teamHiringLev06");
	}
	
	public void moveRefresh(bool TorF)
	{
		this.collider2D.enabled = TorF;
	}
}
