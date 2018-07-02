using UnityEngine;
using System.Collections;

public class timerR2_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebRabbit02;
	private GameObject 	moneyTextRabbit02;
	GameObject rabbit02;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebRabbit02 = GameObject.Find ("highlightZebRabbit02");
		moneyTextRabbit02 = GameObject.Find ("moneyTextRabbit02");
		rabbit02 = GameObject.Find ("rabbit_02");
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
		rabbit02.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebRabbit02 == true)
			{
				Destroy(highlightZebRabbit02);
				Destroy(moneyTextRabbit02);
			}
			
		}
		
		
	}
}
