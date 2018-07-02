using UnityEngine;
using System.Collections;

public class timerSB03_10seconds : MonoBehaviour {
	
	Animator anim;
	private GameObject 	highlightZebSafebox03;
	private GameObject moneySafebox03;
	private GameObject 	moneyTextSafebox03;
	GameObject safeBoxOpened03;


	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		highlightZebSafebox03 = GameObject.Find ("highlightZebSafebox03");
		moneySafebox03 = GameObject.Find ("moneySafebox03");
		moneyTextSafebox03 = GameObject.Find ("moneyTextSafebox03");
		safeBoxOpened03 = GameObject.Find ("safeBoxOpened03");
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
		safeBoxOpened03.audio.Play();
		anim.SetBool("timer10secStart", false);	
		timerDestroy();
	}
	
	public void timerDestroy()
	{
		if (gameObject == true)
		{
			Destroy (gameObject);//self destroy;
			if (highlightZebSafebox03 == true)
			{
				Destroy(highlightZebSafebox03);
				Destroy(moneyTextSafebox03);
			}
	
		}
		
	}
}
