using UnityEngine;
using System.Collections;

public class refreshGame_level10 : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("teamHiringLev10");
	}
	
	public void moveRefresh(bool TorF)
	{
		this.collider2D.enabled = TorF;
	}
}
