using UnityEngine;
using System.Collections;

public class timerSB_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebSafebox;
	private GameObject moneySafebox;
	private GameObject 	moneyTextSafebox;
	GameObject safeBoxOpened;


	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		moneySafebox = GameObject.Find ("moneySafebox");
		moneyTextSafebox = GameObject.Find ("moneyTextSafebox");
		safeBoxOpened = GameObject.Find ("safeBoxOpened");
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
		safeBoxOpened.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebSafebox == true)
			{
				Destroy(highlightZebSafebox);
				Destroy(moneyTextSafebox);
			}
			
		}
		
		
	}
}
