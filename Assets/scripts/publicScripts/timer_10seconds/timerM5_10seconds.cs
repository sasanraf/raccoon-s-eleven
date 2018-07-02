using UnityEngine;
using System.Collections;

public class timerM5_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebMeercat05;
	private GameObject 	moneyTextMeercat05;
	GameObject meercat05;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebMeercat05 = GameObject.Find ("highlightZebMeercat05");
		moneyTextMeercat05 = GameObject.Find ("moneyTextMeercat05");
		meercat05 = GameObject.Find ("meercat_05");
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
		meercat05.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebMeercat05 == true)
			{
				Destroy(highlightZebMeercat05);
				Destroy(moneyTextMeercat05);
			}
			
		}
		
		
	}
}
