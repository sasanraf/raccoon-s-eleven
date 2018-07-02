using UnityEngine;
using System.Collections;

public class timerMonkey_Level_01 : MonoBehaviour {


	Animator anim;
	handMonkey_Level_01 handMonkeyback;
	timerMeercatMoney_level_01 timerMeercatMoneyScript; 

	monkey_Level_01 monkey;
	
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		handMonkeyback = GameObject.Find ("handMonkey").GetComponent<handMonkey_Level_01>();
		monkey = GameObject.Find ("monkey").GetComponent<monkey_Level_01>(); 
		timerMeercatMoneyScript = GameObject.Find("timerObject_10seconds").GetComponent<timerMeercatMoney_level_01>();
	}
	
	public void timerOn()  
	{
		renderer.enabled = true;
		anim.SetBool("timerMonkeyStart", true);	
		StartCoroutine(waitOnPlay());
	}
	
	IEnumerator waitOnPlay() 
	{
		yield return new WaitForSeconds(2f);
		timerMeercatMoneyScript.timerUnhide();
		timeroff();
	}
	
	
	public void timeroff()  
	{
		renderer.enabled = false;
		anim.SetBool("timerMonkeyStart", false);
		monkey.monkeyDone.Play();
		handMonkeyback.handBacktoShelf();
	}
}
