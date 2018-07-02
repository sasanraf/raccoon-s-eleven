using UnityEngine;
using System.Collections;

public class timerT5_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller05;
	private GameObject moneyTeller05;
	private GameObject 	moneyTextTeller05;
	GameObject bankTeller05;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller05 = GameObject.Find ("highlightZebTeller05");
		moneyTeller05 = GameObject.Find ("moneyTeller05");
		moneyTextTeller05 = GameObject.Find ("moneyTextTeller05");
		bankTeller05 = GameObject.Find ("bankTeller05");
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
		bankTeller05.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller05 == true)
			{
				Destroy(highlightZebTeller05);
				Destroy(moneyTeller05);
				Destroy(moneyTextTeller05);
			}
			
		}
		
		
	}
}
