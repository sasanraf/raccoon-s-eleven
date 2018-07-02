using UnityEngine;
using System.Collections;

public class timerT10_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller10;
	private GameObject moneyTeller10;
	private GameObject 	moneyTextTeller10;
	GameObject bankTeller10;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller10 = GameObject.Find ("highlightZebTeller10");
		moneyTeller10 = GameObject.Find ("moneyTeller10");
		moneyTextTeller10 = GameObject.Find ("moneyTextTeller10");
		bankTeller10 = GameObject.Find ("bankTeller10");
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
		bankTeller10.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller10 == true)
			{
				Destroy(highlightZebTeller10);
				Destroy(moneyTeller10);
				Destroy(moneyTextTeller10);
			}
			
		}
		
		
	}
}
