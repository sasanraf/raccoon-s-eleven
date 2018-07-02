using UnityEngine;
using System.Collections;

public class timerMonkey_Level_02 : MonoBehaviour {

	private GameObject monkey;
	monkey_Level_02 monkeyScript;

	//highlights 
	private GameObject highlightZebMeercat01;
	private GameObject highlightZebMeercat02;
	private GameObject highlightZebMeercat03;
	private GameObject highlightZebTeller01;
	private GameObject highlightZebTeller03;
	
	public bool monkeyFinishedMeercat01 = false;
	public bool monkeyFinishedMeercat02 = false;
	public bool monkeyFinishedMeercat03 = false;
	public bool monkeyFinishedTeller01 = false;
	public bool monkeyFinishedTeller03 = false;

	private GameObject moneyTeller01;
	private GameObject moneyTeller03;
	
	public bool monkeyFinished = false;
	public bool timerMonkeyIsWorking = false;

	timerM1_10seconds timerM1_10secondsScript;
	timerM2_10seconds timerM2_10secondsScript;
	timerM3_10seconds timerM3_10secondsScript;
	timerT1_10seconds timerT1_10secondsScript;
	timerT3_10seconds timerT3_10secondsScript;

	Animator anim;

	void Start () 
	{
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller03 = GameObject.Find ("moneyTeller03");

		monkey = GameObject.Find ("monkey"); 
		monkeyScript = GameObject.Find("monkey").GetComponent<monkey_Level_02>();

		timerM1_10secondsScript = GameObject.Find("timerM1_10seconds").GetComponent<timerM1_10seconds>();
		timerM2_10secondsScript = GameObject.Find("timerM2_10seconds").GetComponent<timerM2_10seconds>();
		timerM3_10secondsScript = GameObject.Find("timerM3_10seconds").GetComponent<timerM3_10seconds>();
		timerT1_10secondsScript = GameObject.Find("timerT1_10seconds").GetComponent<timerT1_10seconds>();
		timerT3_10secondsScript = GameObject.Find("timerT3_10seconds").GetComponent<timerT3_10seconds>();

		anim = this.GetComponent<Animator>();
	}
	
	public void timerOn()  
	{
		renderer.enabled = true;
		anim.SetBool("timerMonkeyStart", true);	
		StartCoroutine("waitOnPlay");
	}

	IEnumerator waitOnPlay() 
	{
		yield return new WaitForSeconds(2.0f);

		if (monkeyScript.monkeyIsInside == true && highlightZebMeercat01 == true && monkey.transform.position == highlightZebMeercat01.transform.position)
		{
			monkeyFinishedMeercat01 = true;
			timerM1_10secondsScript.timerUnhide();
			monkeyScript.monkeyDone.Play();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebMeercat02 == true && monkey.transform.position == highlightZebMeercat02.transform.position)
		{
			monkeyFinishedMeercat02 = true;
			timerM2_10secondsScript.timerUnhide();
			monkeyScript.monkeyDone.Play();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebMeercat03 == true && monkey.transform.position == highlightZebMeercat03.transform.position)
		{
			monkeyFinishedMeercat03 = true;
			timerM3_10secondsScript.timerUnhide();
			monkeyScript.monkeyDone.Play();
			timeroff();
		}

		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller01 == true && monkey.transform.position == highlightZebTeller01.transform.position)
		{
			monkeyFinishedTeller01 = true;
			moneyTeller01.renderer.enabled = true;
			timerT1_10secondsScript.timerUnhide();
			monkeyScript.monkeyDone.Play();
			timeroff();
		}

		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller03 == true && monkey.transform.position == highlightZebTeller03.transform.position)
		{
			monkeyFinishedTeller03 = true;
			moneyTeller03.renderer.enabled = true;
			timerT3_10secondsScript.timerUnhide();
			monkeyScript.monkeyDone.Play();
			timeroff();
		}
		else
		{
		timeroff();
		}
	}

	
	public void timeroff()  
	{
		renderer.enabled = false;
		anim.SetBool("timerMonkeyStart", false);
	}
}
