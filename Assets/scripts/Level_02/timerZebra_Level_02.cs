using UnityEngine;
using System.Collections;

public class timerZebra_Level_02 : MonoBehaviour 
{

	private GameObject zebra;
	zebra_Level_02 zebraScript;

	private GameObject HighlightZebMeercat01;
	private GameObject HighlightZebMeercat02;
	private GameObject HighlightZebMeercat03;
	private GameObject HighlightZebTeller01;
	private GameObject HighlightZebTeller03;

	private GameObject dummyHighlightZebMeercat01;
	private GameObject dummyHighlightZebMeercat02;
	private GameObject dummyHighlightZebMeercat03;
	private GameObject dummyHighlightZebTeller01;
	private GameObject dummyHighlightZebTeller03;

	public bool zebraFinishedMeercat01 = false;
	public bool zebraFinishedMeercat02 = false;
	public bool zebraFinishedMeercat03 = false;
	public bool zebraFinishedTeller01 = false;
	public bool zebraFinishedTeller03 = false;

	private GameObject moneyTextMeercat01;
	private GameObject moneyTextMeercat02;
	private GameObject moneyTextMeercat03;
	private GameObject moneyTextTeller01;
	private GameObject moneyTextTeller03;

	GameObject timerM1_10secondsObject;
	GameObject timerM2_10secondsObject;
	GameObject timerM3_10secondsObject;
	GameObject timerT1_10secondsObject;
	GameObject timerT3_10secondsObject;
	
	private GameObject moneyTeller01;
	private GameObject moneyTeller03;

	gameScore_Level_02 scoreMoney;

	Animator anim;
	
	void Start () 
	{
		HighlightZebMeercat01 = GameObject.Find ("HighlightZebMeercat01");
		HighlightZebMeercat02 = GameObject.Find ("HighlightZebMeercat02");
		HighlightZebMeercat03 = GameObject.Find ("HighlightZebMeercat03");
		HighlightZebTeller01 = GameObject.Find ("HighlightZebTeller01");
		HighlightZebTeller03 = GameObject.Find ("HighlightZebTeller03");

		dummyHighlightZebMeercat01 = GameObject.Find ("dummyHighlightZebMeercat01");
		dummyHighlightZebMeercat02 = GameObject.Find ("dummyHighlightZebMeercat02");
		dummyHighlightZebMeercat03 = GameObject.Find ("dummyHighlightZebMeercat03");
		dummyHighlightZebTeller01 = GameObject.Find ("dummyHighlightZebTeller01");
		dummyHighlightZebTeller03 = GameObject.Find ("dummyHighlightZebTeller03");

		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		moneyTextMeercat02 = GameObject.Find ("moneyTextMeercat02");
		moneyTextMeercat03 = GameObject.Find ("moneyTextMeercat03");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller03 = GameObject.Find ("moneyTeller03");

		zebra = GameObject.Find ("zebra"); 
		zebraScript = GameObject.Find("zebra").GetComponent<zebra_Level_02>();

		scoreMoney = GameObject.Find("scoreGUItext").GetComponent<gameScore_Level_02>();
		
		timerM1_10secondsObject = GameObject.Find("timerM1_10seconds");
		timerM2_10secondsObject = GameObject.Find("timerM2_10seconds");
		timerM3_10secondsObject = GameObject.Find("timerM3_10seconds");
		timerT1_10secondsObject = GameObject.Find("timerT1_10seconds");
		timerT3_10secondsObject = GameObject.Find("timerT3_10seconds");
		
		anim = this.GetComponent<Animator>();
	}
	
	public void timerOn()  
	{
		renderer.enabled = true;
		anim.SetBool("timerZebraStart", true);	
		StartCoroutine("waitOnPlay");
	}
	
	IEnumerator waitOnPlay() 
	{
		yield return new WaitForSeconds(2.0f);
		
		if (timerM1_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat01.transform.position)
		{
			zebraFinishedMeercat01 = true;
			zebraScript.moneyDone.Play();
			Destroy(moneyTextMeercat01);
			Destroy(timerM1_10secondsObject);
			timerOff();
			int meercat01Money = scoreMoney.moneyRandomMeercat01;
			scoreMoney.levelScore(meercat01Money);

		}
		
		else if (timerM2_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat02.transform.position)
		{
			zebraFinishedMeercat02 = true;
			zebraScript.moneyDone.Play();
			Destroy(moneyTextMeercat02);
			Destroy(timerM2_10secondsObject);
			timerOff();
			int meercat02Money = scoreMoney.moneyRandomMeercat02;
			scoreMoney.levelScore(meercat02Money);
		}
		
		else if (timerM3_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat03.transform.position)
		{
			zebraFinishedMeercat03 = true;
			zebraScript.moneyDone.Play();
			Destroy(moneyTextMeercat03);
			Destroy(timerM3_10secondsObject);
			timerOff();
			int meercat03Money = scoreMoney.moneyRandomMeercat03;
			scoreMoney.levelScore(meercat03Money);
		}
		
		else if (timerT1_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller01.transform.position)
		{
			zebraFinishedTeller01 = true;
			zebraScript.moneyDone.Play();
			Destroy(moneyTextTeller01);
			Destroy(timerT1_10secondsObject);
			Destroy(moneyTeller01);
			timerOff();
			int teller01Money = scoreMoney.moneyRandomTeller01;
			scoreMoney.levelScore(teller01Money);
		}
		
		else if (timerT3_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller03.transform.position)
		{
			zebraFinishedTeller03 = true;
			zebraScript.moneyDone.Play();
			Destroy(moneyTextTeller03);
			Destroy(timerT3_10secondsObject);
			Destroy(moneyTeller03);
			timerOff();
			int teller03Money = scoreMoney.moneyRandomTeller03;
			scoreMoney.levelScore(teller03Money);
		}
		else
		{
			timerOff();
		}
	}
	
	
	public void timerOff()  
	{
		renderer.enabled = false;
		anim.SetBool("timerZebraStart", false);
	}
}
