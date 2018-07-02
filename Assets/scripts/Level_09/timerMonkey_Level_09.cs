using UnityEngine;
using System.Collections;

public class timerMonkey_Level_09 : MonoBehaviour {

	private GameObject monkey;
	monkey_Level_09 monkeyScript;

	//highlights 
	GameObject highlightZebMeercat01;
	GameObject highlightZebRabbit01;
	GameObject highlightZebRabbit02;
	GameObject highlightZebRabbit03;
	GameObject highlightZebRabbit04;
	GameObject highlightZebTeller01;
	GameObject highlightZebTeller02;
	GameObject highlightZebTeller03;
	GameObject highlightZebTeller04;
	
	public bool monkeyFinishedMeercat01 = false;
	public bool monkeyFinishedRabbit01 = false;
	public bool monkeyFinishedRabbit02 = false;
	public bool monkeyFinishedRabbit03 = false;
	public bool monkeyFinishedRabbit04 = false;
	public bool monkeyFinishedTeller01 = false;
	public bool monkeyFinishedTeller02 = false;
	public bool monkeyFinishedTeller03 = false;
	public bool monkeyFinishedTeller04 = false;
	
	private GameObject moneyTeller01;
	private GameObject moneyTeller02;
	private GameObject moneyTeller03;
	private GameObject moneyTeller04;

	public bool monkeyFinished = false;
	public bool timerMonkeyIsWorking = false;

	timerM1_10seconds timerM1_10secondsScript;
	timerR1_10seconds timerR1_10secondsScript;
	timerR2_10seconds timerR2_10secondsScript;
	timerR3_10seconds timerR3_10secondsScript;
	timerR4_10seconds timerR4_10secondsScript;
	timerT1_10seconds timerT1_10secondsScript;
	timerT2_10seconds timerT2_10secondsScript;
	timerT3_10seconds timerT3_10secondsScript;
	timerT4_10seconds timerT4_10secondsScript;
	timerT5_10seconds timerT5_10secondsScript;
	timerT6_10seconds timerT6_10secondsScript;
	
	Animator anim;

	void Start () 
	{
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebRabbit01 = GameObject.Find ("highlightZebRabbit01");
		highlightZebRabbit02 = GameObject.Find ("highlightZebRabbit02");
		highlightZebRabbit03 = GameObject.Find ("highlightZebRabbit03");
		highlightZebRabbit04 = GameObject.Find ("highlightZebRabbit04");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller02 = GameObject.Find ("highlightZebTeller02");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		highlightZebTeller04 = GameObject.Find ("highlightZebTeller04");
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller02 = GameObject.Find ("moneyTeller02");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		moneyTeller04 = GameObject.Find ("moneyTeller04");

		monkey = GameObject.Find ("monkey"); 
		monkeyScript = GameObject.Find("monkey").GetComponent<monkey_Level_09>();

		timerM1_10secondsScript = GameObject.Find("timerM1_10seconds").GetComponent<timerM1_10seconds>();
		timerR1_10secondsScript = GameObject.Find("timerR1_10seconds").GetComponent<timerR1_10seconds>();
		timerR2_10secondsScript = GameObject.Find("timerR2_10seconds").GetComponent<timerR2_10seconds>();
		timerR3_10secondsScript = GameObject.Find("timerR3_10seconds").GetComponent<timerR3_10seconds>();
		timerR4_10secondsScript = GameObject.Find("timerR4_10seconds").GetComponent<timerR4_10seconds>();
		timerT1_10secondsScript = GameObject.Find("timerT1_10seconds").GetComponent<timerT1_10seconds>();
		timerT2_10secondsScript = GameObject.Find("timerT2_10seconds").GetComponent<timerT2_10seconds>();
		timerT3_10secondsScript = GameObject.Find("timerT3_10seconds").GetComponent<timerT3_10seconds>();
		timerT4_10secondsScript = GameObject.Find("timerT4_10seconds").GetComponent<timerT4_10seconds>();
		
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
			monkeyScript.moneyDone.Play();
			monkeyFinishedMeercat01 = true;
			timerM1_10secondsScript.timerUnhide();
			timeroff();
		}
		

		else if (monkeyScript.monkeyIsInside == true && highlightZebRabbit01 == true && monkey.transform.position == highlightZebRabbit01.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedRabbit01 = true;
			timerR1_10secondsScript.timerUnhide();
			timeroff();
		}

		else if (monkeyScript.monkeyIsInside == true && highlightZebRabbit02 == true && monkey.transform.position == highlightZebRabbit02.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedRabbit02 = true;
			timerR2_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebRabbit03 == true && monkey.transform.position == highlightZebRabbit03.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedRabbit03 = true;
			timerR3_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebRabbit04 == true && monkey.transform.position == highlightZebRabbit04.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedRabbit04 = true;
			timerR4_10secondsScript.timerUnhide();
			timeroff();
		}

		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller01 == true && monkey.transform.position == highlightZebTeller01.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller01 = true;
			moneyTeller01.renderer.enabled = true;
			timerT1_10secondsScript.timerUnhide();
			timeroff();

		}

		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller02 == true && monkey.transform.position == highlightZebTeller02.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller02 = true;
			moneyTeller02.renderer.enabled = true;
			timerT2_10secondsScript.timerUnhide();
			timeroff();
		}

		//else if (monkeyScript.monkeyIsInside == true && highlightZebTeller03 == true && monkey.transform.position == highlightZebTeller03.transform.position)
		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller03 == true && monkey.transform.position == highlightZebTeller03.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller03 = true;
			moneyTeller03.renderer.enabled = true;
			timerT3_10secondsScript.timerUnhide();
			timeroff();
		}

		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller04 == true && monkey.transform.position == highlightZebTeller04.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller04 = true;
			moneyTeller04.renderer.enabled = true;
			timerT4_10secondsScript.timerUnhide();
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
