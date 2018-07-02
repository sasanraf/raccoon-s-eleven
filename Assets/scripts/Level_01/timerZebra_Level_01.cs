using UnityEngine;
using System.Collections;

public class timerZebra_Level_01 : MonoBehaviour {

	Animator anim;
	handZebra_Level_01 handZebraback;
	GameObject customersMoney;
	private GameObject timerMeercatMoney;

	zebra_Level_01 zebra;
	
	void Start () 
	{
		renderer.enabled = false;
		anim = this.GetComponent<Animator>();
		handZebraback = GameObject.Find ("handZebra").GetComponent<handZebra_Level_01>();
		customersMoney = GameObject.Find ("customersMoney");
		timerMeercatMoney = GameObject.Find ("timerObject_10seconds");
		zebra = GameObject.Find ("zebra").GetComponent<zebra_Level_01>(); 
	}
	
	public void timerOn()  
	{
		renderer.enabled = true;
		anim.SetBool("timerZebraStart", true);
		Destroy(timerMeercatMoney);
		StartCoroutine(waitOnPlay());
	}
	
	IEnumerator waitOnPlay() 
	{
		yield return new WaitForSeconds(2f);
		timeroff();
	}
	
	
	public void timeroff()  
	{
		renderer.enabled = false;
		anim.SetBool("timerZebraStart", false);
		zebra.zebraDone.Play();
		handZebraback.handBacktoShelf();
		customersMoney.renderer.enabled = false;
	}
}
