using UnityEngine;
using System.Collections;

public class timerSB02_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebSafebox02;
	private GameObject moneySafebox02;
	private GameObject 	moneyTextSafebox02;
	GameObject safeBoxOpened02;


	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");
		moneySafebox02 = GameObject.Find ("moneySafebox02");
		moneyTextSafebox02 = GameObject.Find ("moneyTextSafebox02");
		safeBoxOpened02 = GameObject.Find ("safeBoxOpened02");
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
		safeBoxOpened02.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebSafebox02 == true)
			{
				Destroy(highlightZebSafebox02);
				Destroy(moneyTextSafebox02);
			}
	
		}
		
	}
}
