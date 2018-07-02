using UnityEngine;
using System.Collections;

public class shelfScaleControl : MonoBehaviour {
	
	pauseBarScale pauseBarScript;
	pauseEndScale pauseEndScript;
	
	// Use this for initialization
	void Start () 
	{
		
		pauseBarScript = GameObject.Find ("pauseBar").GetComponent<pauseBarScale>();
		pauseEndScript = GameObject.Find ("pauseEnd").GetComponent<pauseEndScale>();
		
		if (PlayerPrefs.GetString("chaPos4") != "")
		{
			pauseBarScript.scaleFourCha();
			pauseEndScript.scaleFourCha();
		}
		
		else if (PlayerPrefs.GetString("chaPos3") != "")
		{
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
		}
		
		else if (PlayerPrefs.GetString("chaPos2") != "")
		{
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
		}
		
		else if (PlayerPrefs.GetString("chaPos1") != "")
		{
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
		}
		
	}
	
	
	
}
