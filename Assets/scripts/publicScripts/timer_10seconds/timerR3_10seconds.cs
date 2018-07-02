using UnityEngine;
using System.Collections;

public class timerR3_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebRabbit03;
	private GameObject 	moneyTextRabbit03;
	GameObject rabbit03;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebRabbit03 = GameObject.Find ("highlightZebRabbit03");
		moneyTextRabbit03 = GameObject.Find ("moneyTextRabbit03");
		rabbit03 = GameObject.Find ("rabbit_03");
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
		rabbit03.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebRabbit03 == true)
			{
				Destroy(highlightZebRabbit03);
				Destroy(moneyTextRabbit03);
			}
			
		}
		
		
	}
}
