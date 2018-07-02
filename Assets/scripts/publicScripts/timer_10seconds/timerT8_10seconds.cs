using UnityEngine;
using System.Collections;

public class timerT8_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller08;
	private GameObject moneyTeller08;
	private GameObject 	moneyTextTeller08;
	GameObject bankTeller08;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller08 = GameObject.Find ("highlightZebTeller08");
		moneyTeller08 = GameObject.Find ("moneyTeller08");
		moneyTextTeller08 = GameObject.Find ("moneyTextTeller08");
		bankTeller08 = GameObject.Find ("bankTeller08");
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
		bankTeller08.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller08 == true)
			{
				Destroy(highlightZebTeller08);
				Destroy(moneyTeller08);
				Destroy(moneyTextTeller08);
			}
			
		}
		
		
	}
}
