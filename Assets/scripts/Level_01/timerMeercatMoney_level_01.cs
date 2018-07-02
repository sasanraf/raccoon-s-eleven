using UnityEngine;
using System.Collections;

public class timerMeercatMoney_level_01 : MonoBehaviour {

	Animator anim;
	private GameObject highLightZebra;
	string currentLevelName;


	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highLightZebra = GameObject.Find ("highLightZebra");
		currentLevelName = Application.loadedLevelName;	

	}

	public void timerUnhide()
	{
		renderer.enabled = true;
		timerOn(18);
	}
	
	public void timerOn(float timerCount)  
	{
		anim.SetBool("timer10secStart", true);	
		StartCoroutine(waitOnPlay(timerCount));
	}
	
	IEnumerator waitOnPlay(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
		timeroff();
	}
	
	public void timeroff()  
	{
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highLightZebra == true)
			{
				Destroy(highLightZebra);
				Application.LoadLevel(currentLevelName);
			}
			
		}

		
	}


}
