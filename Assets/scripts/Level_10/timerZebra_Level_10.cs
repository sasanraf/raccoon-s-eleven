using UnityEngine;
using System.Collections;

public class timerZebra_Level_10 : MonoBehaviour 
{

	GameObject zebra;
	zebra_Level_10 zebraScript;

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
	GameObject highlightZebSafebox;
	GameObject highlightZebSafebox02;
	GameObject highlightZebSafebox03;
	
	GameObject dummyHighlightZebMeercat01;
	GameObject dummyHighlightZebMeercat02;
	GameObject dummyHighlightZebMeercat03;
	GameObject dummyHighlightZebMeercat04;
	GameObject dummyHighlightZebMeercat05;
	GameObject dummyHighlightZebMeercat06;
	GameObject dummyHighlightZebRabbit01;
	GameObject dummyHighlightZebRabbit02;
	GameObject dummyHighlightZebRabbit03;
	GameObject dummyHighlightZebRabbit04;
	GameObject dummyHighlightZebRabbit05;	
	GameObject dummyHighlightZebTeller01;
	GameObject dummyHighlightZebTeller02;
	GameObject dummyHighlightZebTeller03;
	GameObject dummyHighlightZebTeller04;
	GameObject dummyHighlightZebTeller05;
	GameObject dummyHighlightZebTeller06;
	GameObject dummyHighlightZebTeller07;
	GameObject dummyHighlightZebTeller08;
	GameObject dummyHighlightZebTeller09;
	GameObject dummyHighlightZebTeller10;
	GameObject dummyHighlightZebSafebox;
	GameObject dummyHighlightZebSafebox02;
	GameObject dummyHighlightZebSafebox03;

	public bool zebraFinishedMeercat01 = false;
	public bool zebraFinishedMeercat02 = false;
	public bool zebraFinishedMeercat03 = false;
	public bool zebraFinishedMeercat04 = false;
	public bool zebraFinishedMeercat05 = false;
	public bool zebraFinishedMeercat06 = false;
	public bool zebraFinishedRabbit01 = false;
	public bool zebraFinishedRabbit02 = false;
	public bool zebraFinishedRabbit03 = false;
	public bool zebraFinishedRabbit04 = false;
	public bool zebraFinishedRabbit05 = false;
	public bool zebraFinishedTeller01 = false;
	public bool zebraFinishedTeller02 = false;
	public bool zebraFinishedTeller03 = false;
	public bool zebraFinishedTeller04 = false;
	public bool zebraFinishedTeller05 = false;
	public bool zebraFinishedTeller06 = false;
	public bool zebraFinishedTeller07 = false;
	public bool zebraFinishedTeller08 = false;
	public bool zebraFinishedTeller09 = false;
	public bool zebraFinishedTeller10 = false;
	public bool zebraFinishedSafebox = false;
	public bool zebraFinishedSafebox02 = false;
	public bool zebraFinishedSafebox03 = false;
	
	GameObject moneyTextMeercat01;
	GameObject moneyTextMeercat02;
	GameObject moneyTextMeercat03;
	GameObject moneyTextMeercat04;
	GameObject moneyTextMeercat05;
	GameObject moneyTextMeercat06;
	GameObject moneyTextRabbit01;
	GameObject moneyTextRabbit02;
	GameObject moneyTextRabbit03;
	GameObject moneyTextRabbit04;
	GameObject moneyTextRabbit05;
	GameObject moneyTextTeller01;
	GameObject moneyTextTeller02;
	GameObject moneyTextTeller03;
	GameObject moneyTextTeller04;
	GameObject moneyTextTeller05;
	GameObject moneyTextTeller06;
	GameObject moneyTextTeller07;
	GameObject moneyTextTeller08;
	GameObject moneyTextTeller09;
	GameObject moneyTextTeller10;
	GameObject moneyTextSafebox;
	GameObject moneyTextSafebox02;
	GameObject moneyTextSafebox03;
	
	GameObject timerM1_10secondsObject;
	GameObject timerM2_10secondsObject;
	GameObject timerM3_10secondsObject;
	GameObject timerM4_10secondsObject;
	GameObject timerM5_10secondsObject;
	GameObject timerM6_10secondsObject;
	GameObject timerR1_10secondsObject;
	GameObject timerR2_10secondsObject;
	GameObject timerR3_10secondsObject;
	GameObject timerR4_10secondsObject;
	GameObject timerR5_10secondsObject;
	GameObject timerT1_10secondsObject;
	GameObject timerT2_10secondsObject;
	GameObject timerT3_10secondsObject;
	GameObject timerT4_10secondsObject;
	GameObject timerT5_10secondsObject;
	GameObject timerT6_10secondsObject;
	GameObject timerT7_10secondsObject;
	GameObject timerT8_10secondsObject;
	GameObject timerT9_10secondsObject;
	GameObject timerT10_10secondsObject;
	GameObject timerSB_10secondsObject;
	GameObject timerSB02_10secondsObject;	
	GameObject timerSB03_10secondsObject;
	
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
	GameObject moneySafebox;
	GameObject moneySafebox02;	
	GameObject moneySafebox03;	
	
	gameScore_Level_10 scoreMoney;

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
		highlightZebSafebox  = GameObject.Find ("highlightZebSafebox");
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");
		highlightZebSafebox03 = GameObject.Find ("highlightZebSafebox03");
		
		dummyHighlightZebMeercat01 = GameObject.Find ("dummyHighlightZebMeercat01");
		dummyHighlightZebMeercat02 = GameObject.Find ("dummyHighlightZebMeercat02");
		dummyHighlightZebMeercat03 = GameObject.Find ("dummyHighlightZebMeercat03");
		dummyHighlightZebMeercat04 = GameObject.Find ("dummyHighlightZebMeercat04");
		dummyHighlightZebMeercat05 = GameObject.Find ("dummyHighlightZebMeercat05");
		dummyHighlightZebMeercat06 = GameObject.Find ("dummyHighlightZebMeercat06");
		dummyHighlightZebRabbit01 = GameObject.Find ("dummyHighlightZebRabbit01");
		dummyHighlightZebRabbit02 = GameObject.Find ("dummyHighlightZebRabbit02");
		dummyHighlightZebRabbit03 = GameObject.Find ("dummyHighlightZebRabbit03");
		dummyHighlightZebRabbit04 = GameObject.Find ("dummyHighlightZebRabbit04");
		dummyHighlightZebRabbit05 = GameObject.Find ("dummyHighlightZebRabbit05");
		dummyHighlightZebTeller01 = GameObject.Find ("dummyHighlightZebTeller01");
		dummyHighlightZebTeller02 = GameObject.Find ("dummyHighlightZebTeller02");
		dummyHighlightZebTeller03 = GameObject.Find ("dummyHighlightZebTeller03");
		dummyHighlightZebTeller04 = GameObject.Find ("dummyHighlightZebTeller04");
		dummyHighlightZebTeller05 = GameObject.Find ("dummyHighlightZebTeller05");
		dummyHighlightZebTeller06 = GameObject.Find ("dummyHighlightZebTeller06");
		dummyHighlightZebTeller07 = GameObject.Find ("dummyHighlightZebTeller07");
		dummyHighlightZebTeller08 = GameObject.Find ("dummyHighlightZebTeller08");
		dummyHighlightZebTeller09 = GameObject.Find ("dummyHighlightZebTeller09");
		dummyHighlightZebTeller10 = GameObject.Find ("dummyHighlightZebTeller10");
		dummyHighlightZebSafebox = GameObject.Find ("dummyHighlightZebSafebox");
		dummyHighlightZebSafebox02 = GameObject.Find ("dummyHighlightZebSafebox02");
		dummyHighlightZebSafebox03 = GameObject.Find ("dummyHighlightZebSafebox03");
		
		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		moneyTextMeercat02 = GameObject.Find ("moneyTextMeercat02");
		moneyTextMeercat03 = GameObject.Find ("moneyTextMeercat03");
		moneyTextMeercat04 = GameObject.Find ("moneyTextMeercat04");
		moneyTextMeercat05 = GameObject.Find ("moneyTextMeercat05");
		moneyTextMeercat06 = GameObject.Find ("moneyTextMeercat06");
		moneyTextRabbit01 = GameObject.Find ("moneyTextRabbit01");
		moneyTextRabbit02 = GameObject.Find ("moneyTextRabbit02");
		moneyTextRabbit03 = GameObject.Find ("moneyTextRabbit03");
		moneyTextRabbit04 = GameObject.Find ("moneyTextRabbit04");
		moneyTextRabbit05 = GameObject.Find ("moneyTextRabbit05");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		moneyTextTeller02 = GameObject.Find ("moneyTextTeller02");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		moneyTextTeller04 = GameObject.Find ("moneyTextTeller04");
		moneyTextTeller05 = GameObject.Find ("moneyTextTeller05");
		moneyTextTeller06 = GameObject.Find ("moneyTextTeller06");
		moneyTextTeller07 = GameObject.Find ("moneyTextTeller07");
		moneyTextTeller08 = GameObject.Find ("moneyTextTeller08");
		moneyTextTeller09 = GameObject.Find ("moneyTextTeller09");
		moneyTextTeller10 = GameObject.Find ("moneyTextTeller10");
		moneyTextSafebox = GameObject.Find("moneyTextSafebox");
		moneyTextSafebox02 = GameObject.Find("moneyTextSafebox02");
		moneyTextSafebox03 = GameObject.Find("moneyTextSafebox03");
		
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
		moneySafebox = GameObject.Find ("moneySafebox");
		moneySafebox02 = GameObject.Find ("moneySafebox02");
		moneySafebox03 = GameObject.Find ("moneySafebox03");

		zebra = GameObject.Find ("zebra"); 
		zebraScript = GameObject.Find("zebra").GetComponent<zebra_Level_10>();

		scoreMoney = GameObject.Find("scoreGUItext").GetComponent<gameScore_Level_10>();
		
		timerM1_10secondsObject = GameObject.Find("timerM1_10seconds");
		timerM2_10secondsObject = GameObject.Find("timerM2_10seconds");
		timerM3_10secondsObject = GameObject.Find("timerM3_10seconds");
		timerM4_10secondsObject = GameObject.Find("timerM4_10seconds");
		timerM5_10secondsObject = GameObject.Find("timerM5_10seconds");
		timerM6_10secondsObject = GameObject.Find("timerM6_10seconds");		
		timerR1_10secondsObject = GameObject.Find("timerR1_10seconds");
		timerR2_10secondsObject = GameObject.Find("timerR2_10seconds");
		timerR3_10secondsObject = GameObject.Find("timerR3_10seconds");
		timerR4_10secondsObject = GameObject.Find("timerR4_10seconds");
		timerR5_10secondsObject = GameObject.Find("timerR5_10seconds");
		timerT1_10secondsObject = GameObject.Find("timerT1_10seconds");
		timerT2_10secondsObject = GameObject.Find("timerT2_10seconds");
		timerT3_10secondsObject = GameObject.Find("timerT3_10seconds");
		timerT4_10secondsObject = GameObject.Find("timerT4_10seconds");
		timerT5_10secondsObject = GameObject.Find("timerT5_10seconds");
		timerT6_10secondsObject = GameObject.Find("timerT6_10seconds");
		timerT7_10secondsObject = GameObject.Find("timerT7_10seconds");
		timerT8_10secondsObject = GameObject.Find("timerT8_10seconds");
		timerT9_10secondsObject = GameObject.Find("timerT9_10seconds");
		timerT10_10secondsObject = GameObject.Find("timerT10_10seconds");
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
		
		else if (timerM2_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat02.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedMeercat02 = true;
			Destroy(moneyTextMeercat02);
			Destroy(timerM2_10secondsObject);
			timerOff();
			int meercat02Money = scoreMoney.moneyRandomMeercat02;
			scoreMoney.levelScore(meercat02Money);

		}
		
		else if (timerM3_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat03.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedMeercat03 = true;
			Destroy(moneyTextMeercat03);
			Destroy(timerM3_10secondsObject);
			timerOff();
			int meercat03Money = scoreMoney.moneyRandomMeercat03;
			scoreMoney.levelScore(meercat03Money);

		}
		
		else if (timerM4_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat04.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedMeercat04 = true;
			Destroy(moneyTextMeercat04);
			Destroy(timerM4_10secondsObject);
			timerOff();
			int meercat04Money = scoreMoney.moneyRandomMeercat04;
			scoreMoney.levelScore(meercat04Money);

		}
		
		else if (timerM5_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat05.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedMeercat05 = true;
			Destroy(moneyTextMeercat05);
			Destroy(timerM5_10secondsObject);
			timerOff();
			int meercat05Money = scoreMoney.moneyRandomMeercat05;
			scoreMoney.levelScore(meercat05Money);

		}
		
		else if (timerM6_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebMeercat06.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedMeercat06 = true;
			Destroy(moneyTextMeercat06);
			Destroy(timerM6_10secondsObject);
			timerOff();
			int meercat06Money = scoreMoney.moneyRandomMeercat06;
			scoreMoney.levelScore(meercat06Money);

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
		
		else if (timerR5_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebRabbit05.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedRabbit05 = true;
			Destroy(moneyTextRabbit05);
			Destroy(timerR5_10secondsObject);
			timerOff();
			int rabbit05Money = scoreMoney.moneyRandomRabbit05;
			scoreMoney.levelScore(rabbit05Money);
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
		
		else if (timerT5_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller05.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller05 = true;
			Destroy(moneyTextTeller05);
			Destroy(timerT5_10secondsObject);
			Destroy(moneyTeller05);
			timerOff();
			int teller05Money = scoreMoney.moneyRandomTeller05;
			scoreMoney.levelScore(teller05Money);
		}
		
		else if (timerT6_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller06.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller06 = true;
			Destroy(moneyTextTeller06);
			Destroy(timerT6_10secondsObject);
			Destroy(moneyTeller06);
			timerOff();
			int teller06Money = scoreMoney.moneyRandomTeller06;
			scoreMoney.levelScore(teller06Money);
		}
		
		else if (timerT7_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller07.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller07 = true;
			Destroy(moneyTextTeller07);
			Destroy(timerT7_10secondsObject);
			Destroy(moneyTeller07);
			timerOff();
			int teller07Money = scoreMoney.moneyRandomTeller07;
			scoreMoney.levelScore(teller07Money);
		}
		
		else if (timerT8_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller08.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller08 = true;
			Destroy(moneyTextTeller08);
			Destroy(timerT8_10secondsObject);
			Destroy(moneyTeller08);
			timerOff();
			int teller08Money = scoreMoney.moneyRandomTeller08;
			scoreMoney.levelScore(teller08Money);
		}
		
		else if (timerT9_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller09.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller09 = true;
			Destroy(moneyTextTeller09);
			Destroy(timerT9_10secondsObject);
			Destroy(moneyTeller09);
			timerOff();
			int teller09Money = scoreMoney.moneyRandomTeller09;
			scoreMoney.levelScore(teller09Money);
		}
		
		else if (timerT10_10secondsObject && zebraScript.zebraIsInside == true && zebra.transform.position == dummyHighlightZebTeller10.transform.position)
		{
			zebraScript.moneyDone.Play();
			zebraFinishedTeller10 = true;
			Destroy(moneyTextTeller10);
			Destroy(timerT10_10secondsObject);
			Destroy(moneyTeller10);
			timerOff();
			int teller10Money = scoreMoney.moneyRandomTeller10;
			scoreMoney.levelScore(teller10Money);
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
