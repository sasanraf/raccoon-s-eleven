using UnityEngine;
using System.Collections;

public class pauseBarScale : MonoBehaviour {

	Animator anim;
	string currentLevelName;
	pauseEndScale pauseEndScript;
	


	void Start () 
	{

		anim = this.GetComponent<Animator>();
		anim.SetInteger("pauseBarCha", 0);

		if (PlayerPrefs.GetString("chaPos4") != "")
		{
			scaleFourCha();
		}
		
		else if (PlayerPrefs.GetString("chaPos3") != "")
		{
			scaleThreeCha();
		}
		
		else if (PlayerPrefs.GetString("chaPos2") != "")
		{
			scaleTwoCha();
		}
		
		else if (PlayerPrefs.GetString("chaPos1") != "")
		{
			scaleOneCha();
		}

		pauseEndScript = GameObject.Find ("pauseEnd").GetComponent<pauseEndScale>();
		currentLevelName = Application.loadedLevelName;

		if (currentLevelName == "teamHiringLev03" || currentLevelName == "teamHiringLev04" || currentLevelName == "teamHiringLev05" || currentLevelName == "teamHiringLev06" || 
		    currentLevelName == "teamHiringLev07" || currentLevelName == "teamHiringLev08" || currentLevelName == "teamHiringLev09" || currentLevelName == "teamHiringLev10" )
		{
			scaleNoCha();
			//pauseEndScript.scaleNoCha();
		}
	}

	public void scaleNoCha() 
	{
		anim.SetInteger("pauseBarCha", 0);
	}

	public void scaleOneCha() 
	{
		anim.SetInteger("pauseBarCha", 1);
	}

	public void scaleTwoCha() 
	{
		anim.SetInteger("pauseBarCha", 2);
	}

	public void scaleThreeCha() 
	{
		anim.SetInteger("pauseBarCha", 3);
	}

	public void scaleFourCha() 
	{
		anim.SetInteger("pauseBarCha", 4);
	}

	
}
