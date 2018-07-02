using UnityEngine;
using System.Collections;

public class timerR1_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebRabbit01;
	private GameObject 	moneyTextRabbit01;
	GameObject rabbit01;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebRabbit01 = GameObject.Find ("highlightZebRabbit01");
		moneyTextRabbit01 = GameObject.Find ("moneyTextRabbit01");
		rabbit01 = GameObject.Find ("rabbit_01");
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
		rabbit01.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebRabbit01 == true)
			{
				Destroy(highlightZebRabbit01);
				Destroy(moneyTextRabbit01);
			}
			
		}
		
		
	}
}
