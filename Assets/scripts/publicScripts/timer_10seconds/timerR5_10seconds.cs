using UnityEngine;
using System.Collections;

public class timerR5_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebRabbit05;
	private GameObject 	moneyTextRabbit05;
	GameObject rabbit05;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebRabbit05 = GameObject.Find ("highlightZebRabbit05");
		moneyTextRabbit05 = GameObject.Find ("moneyTextRabbit05");
		rabbit05 = GameObject.Find ("rabbit_05");
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
		rabbit05.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebRabbit05 == true)
			{
				Destroy(highlightZebRabbit05);
				Destroy(moneyTextRabbit05);
			}
			
		}
		
		
	}
}
