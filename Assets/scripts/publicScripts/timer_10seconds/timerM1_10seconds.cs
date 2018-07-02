using UnityEngine;
using System.Collections;

public class timerM1_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebMeercat01;
	private GameObject 	moneyTextMeercat01;
	GameObject meercat01;

	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		meercat01 = GameObject.Find ("meercat_01");

	}

	public void timerUnhide()
	{
		renderer.enabled = true;
		timerOn(9);
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
		meercat01.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebMeercat01 == true)
			{
				Destroy(highlightZebMeercat01);
				Destroy(moneyTextMeercat01);
			}
			
		}

		
	}


}
