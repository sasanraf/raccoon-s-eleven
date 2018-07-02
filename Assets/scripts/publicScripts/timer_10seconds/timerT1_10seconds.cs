using UnityEngine;
using System.Collections;

public class timerT1_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller01;
	private GameObject moneyTeller01;
	private GameObject 	moneyTextTeller01;
	GameObject bankTeller01;

	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		bankTeller01 = GameObject.Find ("bankTeller01");
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
		bankTeller01.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller01 == true)
			{
				Destroy(highlightZebTeller01);
				Destroy(moneyTeller01);
				Destroy(moneyTextTeller01);
			}
			
		}
		
		
	}
}
