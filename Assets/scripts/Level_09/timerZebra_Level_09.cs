using UnityEngine;
using System.Collections;

public class timerZebra_Level_09 : MonoBehaviour 
{

	private GameObject zebra;
	zebra_Level_09 zebraScript;

	GameObject highlightZebMeercat01;
	GameObject highlightZebRabbit01;
	GameObject highlightZebRabbit02;
	GameObject highlightZebRabbit03;
	GameObject highlightZebRabbit04;
	GameObject highlightZebTeller01;
	GameObject highlightZebTeller02;
	GameObject highlightZebTeller03;
	GameObject highlightZebTeller04;
	GameObject highlightZebSafebox;
	GameObject highlightZebSafebox02;
	GameObject highlightZebSafebox03;
	
	private GameObject dummyHighlightZebMeercat01;
	private GameObject dummyHighlightZebRabbit01;
	private GameObject dummyHighlightZebRabbit02;
	private GameObject dummyHighlightZebRabbit03;
	private GameObject dummyHighlightZebRabbit04;
	private GameObject dummyHighlightZebTeller01;
	private GameObject dummyHighlightZebTeller02;
	private GameObject dummyHighlightZebTeller03;
	private GameObject dummyHighlightZebTeller04;
	private GameObject dummyHighlightZebSafebox;
	private GameObject dummyHighlightZebSafebox02;
	private GameObject dummyHighlightZebSafebox03;

	public bool zebraFinishedMeercat01 = false;
	public bool zebraFinishedRabbit01 = false;
	public bool zebraFinishedRabbit02 = false;
	public bool zebraFinishedRabbit03 = false;
	public bool zebraFinishedRabbit04 = false;
	public bool zebraFinishedTeller01 = false;
	public bool zebraFinishedTeller02 = false;
	public bool zebraFinishedTeller03 = false;
	public bool zebraFinishedTeller04 = false;
	public bool zebraFinishedSafebox = false;
	public bool zebraFinishedSafebox02 = false;
	public bool zebraFinishedSafebox03 = false;
	
	private GameObject moneyTextMeercat01;
	private GameObject moneyTextRabbit01;
	private GameObject moneyTextRabbit02;
	private GameObject moneyTextRabbit03;
	private GameObject moneyTextRabbit04;
	private GameObject moneyTextTeller01;
	private GameObject moneyTextTeller02;
	private GameObject moneyTextTeller03;
	private GameObject moneyTextTeller04;
	private GameObject moneyTextSafebox;
	private GameObject moneyTextSafebox02;
	private GameObject moneyTextSafebox03;
	
	GameObject timerM1_10secondsObject;
	GameObject timerR1_10secondsObject;
	GameObject timerR2_10secondsObject;
	GameObject timerR3_10secondsObject;
	GameObject timerR4_10secondsObject;
	GameObject timerT1_10secondsObject;
	GameObject timerT2_10secondsObject;
	GameObject timerT3_10secondsObject;
	GameObject timerT4_10secondsObject;
	GameObject timerSB_10secondsObject;
	GameObject timerSB02_10secondsObject;	
	GameObject timerSB03_10secondsObject;
	
	private GameObject moneyTeller01;
	private GameObject moneyTeller02;
	private GameObject moneyTeller03;
	private GameObject moneyTeller04;
	private GameObject moneySafebox;
	private GameObject moneySafebox02;	
	private GameObject moneySafebox03;	
	
	gameScore_Level_09 scoreMoney;

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
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");
		highlightZebSafebox03 = GameObject.Find ("highlightZebSafebox03");
		
		dummyHighlightZebMeercat01 = GameObject.Find ("dummyHighlightZebMeercat01");
		dummyHighlightZebRabbit01 = GameObject.Find ("dummyHighlightZebRabbit01");
		dummyHighlightZebRabbit02 = GameObject.Find ("dummyHighlightZebRabbit02");
		dummyHighlightZebRabbit03 = GameObject.Find ("dummyHighlightZebRabbit03");
		dummyHighlightZebRabbit04 = GameObject.Find ("dummyHighlightZebRabbit04");
		dummyHighlightZebTeller01 = GameObject.Find ("dummyHighlightZebTeller01");
		dummyHighlightZebTeller02 = GameObject.Find ("dummyHighlightZebTeller02");
		dummyHighlightZebTeller03 = GameObject.Find ("dummyHighlightZebTeller03");
		dummyHighlightZebTeller04 = GameObject.Find ("dummyHighlightZebTeller04");
		dummyHighlightZebSafebox = GameObject.Find ("dummyHighlightZebSafebox");
		dummyHighlightZebSafebox02 = GameObject.Find ("dummyHighlightZebSafebox02");
		dummyHighlightZebSafebox03 = GameObject.Find ("dummyHighlightZebSafebox03");
		
		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		moneyTextRabbit01 = GameObject.Find ("moneyTextRabbit01");
		moneyTextRabbit02 = GameObject.Find ("moneyTextRabbit02");
		moneyTextRabbit03 = GameObject.Find ("moneyTextRabbit03");
		moneyTextRabbit04 = GameObject.Find ("moneyTextRabbit04");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		moneyTextTeller02 = GameObject.Find ("moneyTextTeller02");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		moneyTextTeller04 = GameObject.Find ("moneyTextTeller04");
		moneyTextSafebox = GameObject.Find("moneyTextSafebox");
		moneyTextSafebox02 = GameObject.Find("moneyTextSafebox02");
		moneyTextSafebox03 = GameObject.Find("moneyTextSafebox03");
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller02 = GameObject.Find ("moneyTeller02");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		moneyTeller04 = GameObject.Find ("moneyTeller04");
		moneySafebox = GameObject.Find ("moneySafebox");
		moneySafebox02 = GameObject.Find ("moneySafebox02");
		moneySafebox03 = GameObject.Find ("moneySafebox03");

		zebra = GameObject.Find ("zebra"); 
		zebraScript = GameObject.Find("zebra").GetComponent<zebra_Level_09>();

		scoreMoney = GameObject.Find("scoreGUItext").GetComponent<gameScore_Level_09>();
		
		timerM1_10secondsObject = GameObject.Find("timerM1_10seconds");
		timerR1_10secondsObject = GameObject.Find("timerR1_10seconds");
		timerR2_10secondsObject = GameObject.Find("timerR2_10seconds");
		timerR3_10secondsObject = GameObject.Find("timerR3_10seconds");
		timerR4_10secondsObject = GameObject.Find("timerR4_10seconds");
		timerT1_10secondsObject = GameObject.Find("timerT1_10seconds");
		timerT2_10secondsObject = GameObject.Find("timerT2_10seconds");
		timerT3_10secondsObject = GameObject.Find("timerT3_10seconds");
		timerT4_10secondsObject = GameObject.Find("timerT4_10seconds");
		timerSB_10secondsObject = GameObject.Find("timerSB_10seconds");
		timerSB02_10secondsObject = GameObject.Find("timerSB02_10seconds");
		timerSB03_10secondsObject = GameObject.Find("timerSB03_10seconds");
		
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
			zebraScript.moneyDone.Play();
			zebraFinishedMeercat01 = true;
			Destroy(moneyTextMeercat01);
			Destroy(timerM1_10secondsObject);
			timerOff();
			int meercat01Money = scoreMoney.moneyRandomMeercat01;
			scoreMoney.levelScore(meercat01Money);

		}


		else if (timerR1_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebRabbit01.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedRabbit01 = true;
			Destroy(moneyTextRabbit01);
			Destroy(timerR1_10secondsObject);
			timerOff();
			int rabbit01Money = scoreMoney.moneyRandomRabbit01;
			scoreMoney.levelScore(rabbit01Money);
		}

		else if (timerR2_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebRabbit02.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedRabbit02 = true;
			Destroy(moneyTextRabbit02);
			Destroy(timerR2_10secondsObject);
			timerOff();
			int rabbit02Money = scoreMoney.moneyRandomRabbit02;
			scoreMoney.levelScore(rabbit02Money);
		}
		
		else if (timerR3_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebRabbit03.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedRabbit03 = true;
			Destroy(moneyTextRabbit03);
			Destroy(timerR3_10secondsObject);
			timerOff();
			int rabbit03Money = scoreMoney.moneyRandomRabbit03;
			scoreMoney.levelScore(rabbit03Money);
		}
		
		else if (timerR4_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebRabbit04.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedRabbit04 = true;
			Destroy(moneyTextRabbit04);
			Destroy(timerR4_10secondsObject);
			timerOff();
			int rabbit04Money = scoreMoney.moneyRandomRabbit04;
			scoreMoney.levelScore(rabbit04Money);
		}
		
		else if (timerT1_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller01.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller01 = true;
			Destroy(moneyTextTeller01);
			Destroy(timerT1_10secondsObject);
			Destroy(moneyTeller01);
			timerOff();
			int teller01Money = scoreMoney.moneyRandomTeller01;
			scoreMoney.levelScore(teller01Money);
		}

		else if (timerT2_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller02.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller02 = true;
			Destroy(moneyTextTeller02);
			Destroy(timerT2_10secondsObject);
			Destroy(moneyTeller02);
			timerOff();
			int teller02Money = scoreMoney.moneyRandomTeller02;
			scoreMoney.levelScore(teller02Money);
		}
		
		else if (timerT3_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller03.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller03 = true;
			Destroy(moneyTextTeller03);
			Destroy(timerT3_10secondsObject);
			Destroy(moneyTeller03);
			timerOff();
			int teller03Money = scoreMoney.moneyRandomTeller03;
			scoreMoney.levelScore(teller03Money);
		}

		else if (timerT4_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller04.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller04 = true;
			Destroy(moneyTextTeller04);
			Destroy(timerT4_10secondsObject);
			Destroy(moneyTeller04);
			timerOff();
			int teller04Money = scoreMoney.moneyRandomTeller04;
			scoreMoney.levelScore(teller04Money);
		}


		else if (timerSB_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebSafebox.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedSafebox = true;
			Destroy(moneyTextSafebox);
			Destroy(timerSB_10secondsObject);
			Destroy(moneySafebox);
			timerOff();
			int safeboxMoney = scoreMoney.moneyRandomSafebox;
			scoreMoney.levelScore(safeboxMoney);
		}
		
		else if (timerSB02_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebSafebox02.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedSafebox02 = true;
			Destroy(moneyTextSafebox02);
			Destroy(timerSB02_10secondsObject);
			Destroy(moneySafebox02);
			timerOff();
			int safeboxMoney02 = scoreMoney.moneyRandomSafebox02;
			scoreMoney.levelScore(safeboxMoney02);
		}	

		else if (timerSB03_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebSafebox03.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedSafebox03 = true;
			Destroy(moneyTextSafebox03);
			Destroy(timerSB03_10secondsObject);
			Destroy(moneySafebox03);
			timerOff();
			int safeboxMoney03 = scoreMoney.moneyRandomSafebox03;
			scoreMoney.levelScore(safeboxMoney03);
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
