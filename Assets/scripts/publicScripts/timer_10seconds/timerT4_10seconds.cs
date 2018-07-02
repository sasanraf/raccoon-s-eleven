using UnityEngine;
using System.Collections;

public class timerT4_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller04;
	private GameObject moneyTeller04;
	private GameObject 	moneyTextTeller04;
	GameObject bankTeller04;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller04 = GameObject.Find ("highlightZebTeller04");
		moneyTeller04 = GameObject.Find ("moneyTeller04");
		moneyTextTeller04 = GameObject.Find ("moneyTextTeller04");
		bankTeller04 = GameObject.Find ("bankTeller04");
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
		bankTeller04.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller04 == true)
			{
				Destroy(highlightZebTeller04);
				Destroy(moneyTeller04);
				Destroy(moneyTextTeller04);
			}
			
		}
		
		
	}
}
