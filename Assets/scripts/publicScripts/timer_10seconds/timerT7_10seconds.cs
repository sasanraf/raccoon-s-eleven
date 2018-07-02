using UnityEngine;
using System.Collections;

public class timerT7_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller07;
	private GameObject moneyTeller07;
	private GameObject 	moneyTextTeller07;
	GameObject bankTeller07;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller07 = GameObject.Find ("highlightZebTeller07");
		moneyTeller07 = GameObject.Find ("moneyTeller07");
		moneyTextTeller07 = GameObject.Find ("moneyTextTeller07");
		bankTeller07 = GameObject.Find ("bankTeller07");
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
		bankTeller07.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller07 == true)
			{
				Destroy(highlightZebTeller07);
				Destroy(moneyTeller07);
				Destroy(moneyTextTeller07);
			}
			
		}
		
		
	}
}
