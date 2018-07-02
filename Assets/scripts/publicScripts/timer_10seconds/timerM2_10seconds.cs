using UnityEngine;
using System.Collections;

public class timerM2_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebMeercat02;
	private GameObject 	moneyTextMeercat02;
	GameObject meercat02;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		moneyTextMeercat02 = GameObject.Find ("moneyTextMeercat02");
		meercat02 = GameObject.Find ("meercat_02");
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
		meercat02.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebMeercat02 == true)
			{
				Destroy(highlightZebMeercat02);
				Destroy(moneyTextMeercat02);
			}
			
		}
		
		
	}
}
