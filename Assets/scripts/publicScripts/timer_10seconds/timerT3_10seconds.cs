using UnityEngine;
using System.Collections;

public class timerT3_10seconds : MonoBehaviour {

	Animator anim;
	private GameObject 	highlightZebTeller03;
	private GameObject moneyTeller03;
	private GameObject 	moneyTextTeller03;
	GameObject bankTeller03;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		bankTeller03 = GameObject.Find ("bankTeller03");
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
		bankTeller03.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebTeller03 == true)
			{
				Destroy(highlightZebTeller03);
				Destroy(moneyTeller03);
				Destroy(moneyTextTeller03);
			}
			
		}
		
		
	}
}
