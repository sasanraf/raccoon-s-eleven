using UnityEngine;
using System.Collections;

public class upgradeButton : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("upgradePage");
	}
}
