using UnityEngine;
using System.Collections;

public class timerM3_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebMeercat03;
	private GameObject 	moneyTextMeercat03;
	GameObject meercat03;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		moneyTextMeercat03 = GameObject.Find ("moneyTextMeercat03");
		meercat03 = GameObject.Find ("meercat_03");
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
		meercat03.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebMeercat03 == true)
			{
				Destroy(highlightZebMeercat03);
				Destroy(moneyTextMeercat03);
			}
			
		}
		
		
	}
}
