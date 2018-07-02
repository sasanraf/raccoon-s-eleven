using UnityEngine;
using System.Collections;

public class timerT9_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller09;
	private GameObject moneyTeller09;
	private GameObject 	moneyTextTeller09;
	GameObject bankTeller09;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller09 = GameObject.Find ("highlightZebTeller09");
		moneyTeller09 = GameObject.Find ("moneyTeller09");
		moneyTextTeller09 = GameObject.Find ("moneyTextTeller09");
		bankTeller09 = GameObject.Find ("bankTeller09");
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
		bankTeller09.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller09 == true)
			{
				Destroy(highlightZebTeller09);
				Destroy(moneyTeller09);
				Destroy(moneyTextTeller09);
			}
			
		}
		
		
	}
}
