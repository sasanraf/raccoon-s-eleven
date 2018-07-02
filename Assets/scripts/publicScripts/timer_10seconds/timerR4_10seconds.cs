using UnityEngine;
using System.Collections;

public class timerR4_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebRabbit04;
	private GameObject 	moneyTextRabbit04;
	GameObject rabbit04;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebRabbit04 = GameObject.Find ("highlightZebRabbit04");
		moneyTextRabbit04 = GameObject.Find ("moneyTextRabbit04");
		rabbit04 = GameObject.Find ("rabbit_04");
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
		rabbit04.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebRabbit04 == true)
			{
				Destroy(highlightZebRabbit04);
				Destroy(moneyTextRabbit04);
			}
			
		}
		
		
	}
}
