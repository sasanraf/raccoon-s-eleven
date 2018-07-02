using UnityEngine;
using System.Collections;

public class timerMonkey_Level_10 : MonoBehaviour {

	GameObject monkey;
	monkey_Level_10 monkeyScript;

	//highlight zebra
	GameObject highlightZebMeercat01;
	GameObject highlightZebMeercat02;
	GameObject highlightZebMeercat03;
	GameObject highlightZebMeercat04;
	GameObject highlightZebMeercat05;
	GameObject highlightZebMeercat06;
	GameObject highlightZebRabbit01;
	GameObject highlightZebRabbit02;
	GameObject highlightZebRabbit03;
	GameObject highlightZebRabbit04;
	GameObject highlightZebRabbit05;	
	GameObject highlightZebTeller01;
	GameObject highlightZebTeller02;
	GameObject highlightZebTeller03;
	GameObject highlightZebTeller04;
	GameObject highlightZebTeller05;
	GameObject highlightZebTeller06;
	GameObject highlightZebTeller07;
	GameObject highlightZebTeller08;
	GameObject highlightZebTeller09;
	GameObject highlightZebTeller10;
	
	public bool monkeyFinishedMeercat01 = false;
	public bool monkeyFinishedMeercat02 = false;
	public bool monkeyFinishedMeercat03 = false;
	public bool monkeyFinishedMeercat04 = false;
	public bool monkeyFinishedMeercat05 = false;
	public bool monkeyFinishedMeercat06 = false;
	public bool monkeyFinishedRabbit01 = false;
	public bool monkeyFinishedRabbit02 = false;
	public bool monkeyFinishedRabbit03 = false;
	public bool monkeyFinishedRabbit04 = false;
	public bool monkeyFinishedRabbit05 = false;
	public bool monkeyFinishedTeller01 = false;
	public bool monkeyFinishedTeller02 = false;
	public bool monkeyFinishedTeller03 = false;
	public bool monkeyFinishedTeller04 = false;
	public bool monkeyFinishedTeller05 = false;
	public bool monkeyFinishedTeller06 = false;
	public bool monkeyFinishedTeller07 = false;
	public bool monkeyFinishedTeller08 = false;
	public bool monkeyFinishedTeller09 = false;
	public bool monkeyFinishedTeller10 = false;
	
	GameObject moneyTeller01;
	GameObject moneyTeller02;
	GameObject moneyTeller03;
	GameObject moneyTeller04;
	GameObject moneyTeller05;
	GameObject moneyTeller06;
	GameObject moneyTeller07;
	GameObject moneyTeller08;
	GameObject moneyTeller09;
	GameObject moneyTeller10;

	public bool monkeyFinished = false;
	public bool timerMonkeyIsWorking = false;

	timerM1_10seconds timerM1_10secondsScript;
	timerM2_10seconds timerM2_10secondsScript;
	timerM3_10seconds timerM3_10secondsScript;
	timerM4_10seconds timerM4_10secondsScript;
	timerM5_10seconds timerM5_10secondsScript;
	timerM6_10seconds timerM6_10secondsScript;
	timerR1_10seconds timerR1_10secondsScript;
	timerR2_10seconds timerR2_10secondsScript;
	timerR3_10seconds timerR3_10secondsScript;
	timerR4_10seconds timerR4_10secondsScript;
	timerR5_10seconds timerR5_10secondsScript;
	timerT1_10seconds timerT1_10secondsScript;
	timerT2_10seconds timerT2_10secondsScript;
	timerT3_10seconds timerT3_10secondsScript;
	timerT4_10seconds timerT4_10secondsScript;
	timerT5_10seconds timerT5_10secondsScript;
	timerT6_10seconds timerT6_10secondsScript;
	timerT7_10seconds timerT7_10secondsScript;
	timerT8_10seconds timerT8_10secondsScript;
	timerT9_10seconds timerT9_10secondsScript;
	timerT10_10seconds timerT10_10secondsScript;
	Animator anim;

	void Start () 
	{
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		highlightZebMeercat04 = GameObject.Find ("highlightZebMeercat04");
		highlightZebMeercat05 = GameObject.Find ("highlightZebMeercat05");
		highlightZebMeercat06 = GameObject.Find ("highlightZebMeercat06");
		highlightZebRabbit01 = GameObject.Find ("highlightZebRabbit01");
		highlightZebRabbit02 = GameObject.Find ("highlightZebRabbit02");
		highlightZebRabbit03 = GameObject.Find ("highlightZebRabbit03");
		highlightZebRabbit04 = GameObject.Find ("highlightZebRabbit04");
		highlightZebRabbit05 = GameObject.Find ("highlightZebRabbit05");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller02 = GameObject.Find ("highlightZebTeller02");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		highlightZebTeller04 = GameObject.Find ("highlightZebTeller04");
		highlightZebTeller05 = GameObject.Find ("highlightZebTeller05");
		highlightZebTeller06 = GameObject.Find ("highlightZebTeller06");
		highlightZebTeller07 = GameObject.Find ("highlightZebTeller07");
		highlightZebTeller08 = GameObject.Find ("highlightZebTeller08");
		highlightZebTeller09 = GameObject.Find ("highlightZebTeller09");
		highlightZebTeller10 = GameObject.Find ("highlightZebTeller10");
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller02 = GameObject.Find ("moneyTeller02");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		moneyTeller04 = GameObject.Find ("moneyTeller04");
		moneyTeller05 = GameObject.Find ("moneyTeller05");
		moneyTeller06 = GameObject.Find ("moneyTeller06");
		moneyTeller07 = GameObject.Find ("moneyTeller07");
		moneyTeller08 = GameObject.Find ("moneyTeller08");
		moneyTeller09 = GameObject.Find ("moneyTeller09");
		moneyTeller10 = GameObject.Find ("moneyTeller10");

		monkey = GameObject.Find ("monkey"); 
		monkeyScript = GameObject.Find("monkey").GetComponent<monkey_Level_10>();

		timerM1_10secondsScript = GameObject.Find("timerM1_10seconds").GetComponent<timerM1_10seconds>();
		timerM2_10secondsScript = GameObject.Find("timerM2_10seconds").GetComponent<timerM2_10seconds>();
		timerM3_10secondsScript = GameObject.Find("timerM3_10seconds").GetComponent<timerM3_10seconds>();
		timerM4_10secondsScript = GameObject.Find("timerM4_10seconds").GetComponent<timerM4_10seconds>();
		timerM5_10secondsScript = GameObject.Find("timerM5_10seconds").GetComponent<timerM5_10seconds>();
		timerM6_10secondsScript = GameObject.Find("timerM6_10seconds").GetComponent<timerM6_10seconds>();
		timerR1_10secondsScript = GameObject.Find("timerR1_10seconds").GetComponent<timerR1_10seconds>();
		timerR2_10secondsScript = GameObject.Find("timerR2_10seconds").GetComponent<timerR2_10seconds>();
		timerR3_10secondsScript = GameObject.Find("timerR3_10seconds").GetComponent<timerR3_10seconds>();
		timerR4_10secondsScript = GameObject.Find("timerR4_10seconds").GetComponent<timerR4_10seconds>();
		timerR5_10secondsScript = GameObject.Find("timerR5_10seconds").GetComponent<timerR5_10seconds>();
		timerT1_10secondsScript = GameObject.Find("timerT1_10seconds").GetComponent<timerT1_10seconds>();
		timerT2_10secondsScript = GameObject.Find("timerT2_10seconds").GetComponent<timerT2_10seconds>();
		timerT3_10secondsScript = GameObject.Find("timerT3_10seconds").GetComponent<timerT3_10seconds>();
		timerT4_10secondsScript = GameObject.Find("timerT4_10seconds").GetComponent<timerT4_10seconds>();
		timerT5_10secondsScript = GameObject.Find("timerT5_10seconds").GetComponent<timerT5_10seconds>();
		timerT6_10secondsScript = GameObject.Find("timerT6_10seconds").GetComponent<timerT6_10seconds>();
		timerT7_10secondsScript = GameObject.Find("timerT7_10seconds").GetComponent<timerT7_10seconds>();
		timerT8_10secondsScript = GameObject.Find("timerT8_10seconds").GetComponent<timerT8_10seconds>();
		timerT9_10secondsScript = GameObject.Find("timerT9_10seconds").GetComponent<timerT9_10seconds>();
		timerT10_10secondsScript = GameObject.Find("timerT10_10seconds").GetComponent<timerT10_10seconds>();
		
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
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebMeercat02 == true && monkey.transform.position == highlightZebMeercat02.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedMeercat02 = true;
			timerM2_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebMeercat03 == true && monkey.transform.position == highlightZebMeercat03.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedMeercat03 = true;
			timerM3_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebMeercat04 == true && monkey.transform.position == highlightZebMeercat04.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedMeercat04 = true;
			timerM4_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebMeercat05 == true && monkey.transform.position == highlightZebMeercat05.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedMeercat05 = true;
			timerM5_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebMeercat06 == true && monkey.transform.position == highlightZebMeercat06.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedMeercat06 = true;
			timerM6_10secondsScript.timerUnhide();
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

		else if (monkeyScript.monkeyIsInside == true && highlightZebRabbit05 == true && monkey.transform.position == highlightZebRabbit05.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedRabbit05 = true;
			timerR5_10secondsScript.timerUnhide();
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
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller05 == true && monkey.transform.position == highlightZebTeller05.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller05 = true;
			moneyTeller05.renderer.enabled = true;
			timerT5_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller06 == true && monkey.transform.position == highlightZebTeller06.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller06 = true;
			moneyTeller06.renderer.enabled = true;
			timerT6_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller07 == true && monkey.transform.position == highlightZebTeller07.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller07 = true;
			moneyTeller07.renderer.enabled = true;
			timerT7_10secondsScript.timerUnhide();
			timeroff();
		}
		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller08 == true && monkey.transform.position == highlightZebTeller08.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller08 = true;
			moneyTeller08.renderer.enabled = true;
			timerT8_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller09 == true && monkey.transform.position == highlightZebTeller09.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller09 = true;
			moneyTeller09.renderer.enabled = true;
			timerT9_10secondsScript.timerUnhide();
			timeroff();
		}
		
		else if (monkeyScript.monkeyIsInside == true && highlightZebTeller10 == true && monkey.transform.position == highlightZebTeller10.transform.position)
		{
			monkeyScript.moneyDone.Play();
			monkeyFinishedTeller10 = true;
			moneyTeller10.renderer.enabled = true;
			timerT10_10secondsScript.timerUnhide();
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
