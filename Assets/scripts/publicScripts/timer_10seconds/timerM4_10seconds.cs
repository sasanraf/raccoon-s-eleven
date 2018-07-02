using UnityEngine;
using System.Collections;

public class timerM4_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebMeercat04;
	private GameObject 	moneyTextMeercat04;
	GameObject meercat04;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebMeercat04 = GameObject.Find ("highlightZebMeercat04");
		moneyTextMeercat04 = GameObject.Find ("moneyTextMeercat04");
		meercat04 = GameObject.Find ("meercat_04");
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
		meercat04.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebMeercat04 == true)
			{
				Destroy(highlightZebMeercat04);
				Destroy(moneyTextMeercat04);
			}
			
		}
		
		
	}
}
