using UnityEngine;
using System.Collections;

public class timerM6_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebMeercat06;
	private GameObject 	moneyTextMeercat06;
	GameObject meercat06;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebMeercat06 = GameObject.Find ("highlightZebMeercat06");
		moneyTextMeercat06 = GameObject.Find ("moneyTextMeercat06");
		meercat06 = GameObject.Find ("meercat_06");
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
		meercat06.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebMeercat06 == true)
			{
				Destroy(highlightZebMeercat06);
				Destroy(moneyTextMeercat06);
			}
			
		}
		
		
	}
}
