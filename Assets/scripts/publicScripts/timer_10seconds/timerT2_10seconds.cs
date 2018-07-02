using UnityEngine;
using System.Collections;

public class timerT2_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller02;
	private GameObject moneyTeller02;
	private GameObject 	moneyTextTeller02;
	GameObject bankTeller02;

	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller02 = GameObject.Find ("highlightZebTeller02");
		moneyTeller02 = GameObject.Find ("moneyTeller02");
		moneyTextTeller02 = GameObject.Find ("moneyTextTeller02");
		bankTeller02 = GameObject.Find ("bankTeller02");
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
		bankTeller02.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller02 == true)
			{
				Destroy(highlightZebTeller02);
				Destroy(moneyTeller02);
				Destroy(moneyTextTeller02);
			}
			
		}
		
		
	}
}
