using UnityEngine;
using System.Collections;

public class timerT6_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller06;
	private GameObject moneyTeller06;
	private GameObject 	moneyTextTeller06;
	GameObject bankTeller06;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller06 = GameObject.Find ("highlightZebTeller06");
		moneyTeller06 = GameObject.Find ("moneyTeller06");
		moneyTextTeller06 = GameObject.Find ("moneyTextTeller06");
		bankTeller06 = GameObject.Find ("bankTeller06");
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
		bankTeller06.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller06 == true)
			{
				Destroy(highlightZebTeller06);
				Destroy(moneyTeller06);
				Destroy(moneyTextTeller06);
			}
			
		}
		
		
	}
}
