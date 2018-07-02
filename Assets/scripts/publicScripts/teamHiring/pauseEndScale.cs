using UnityEngine;
using System.Collections;

public class pauseEndScale : MonoBehaviour {

	Animator anim;


	
	void Start () 
	{

		anim = this.GetComponent<Animator>();
		anim.SetInteger("pauseEndCha", 0);

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
	}

	public void scaleNoCha() 
	{
		anim.SetInteger("pauseEndCha", 0);
	}

	public void scaleOneCha() 
	{
		anim.SetInteger("pauseEndCha", 1);
	}

	public void scaleTwoCha() 
	{
		anim.SetInteger("pauseEndCha", 2);
	}
	
	public void scaleThreeCha() 
	{
		anim.SetInteger("pauseEndCha", 3);
	}

	public void scaleFourCha() 
	{
		anim.SetInteger("pauseEndCha", 4);
	}


}
