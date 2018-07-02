using UnityEngine;
using System.Collections;

public class timerZebra_Level_05 : MonoBehaviour 
{

	private GameObject zebra;
	zebra_Level_05 zebraScript;

	GameObject highlightZebMeercat01;
	GameObject highlightZebMeercat02;
	GameObject highlightZebMeercat03;
	GameObject highlightZebMeercat04;
	GameObject highlightZebRabbit01;
	GameObject highlightZebRabbit02;
	GameObject highlightZebRabbit03;
	GameObject highlightZebRabbit04;
	GameObject highlightZebTeller01;
	GameObject highlightZebTeller02;
	GameObject highlightZebTeller03;
	GameObject highlightZebTeller04;
	GameObject highlightZebTeller05;
	GameObject highlightZebTeller06;
	GameObject highlightZebSafebox;

	private GameObject dummyHighlightZebMeercat01;
	private GameObject dummyHighlightZebMeercat02;
	private GameObject dummyHighlightZebMeercat03;
	private GameObject dummyHighlightZebMeercat04;
	private GameObject dummyHighlightZebRabbit01;
	private GameObject dummyHighlightZebRabbit02;
	private GameObject dummyHighlightZebRabbit03;
	private GameObject dummyHighlightZebRabbit04;
	private GameObject dummyHighlightZebTeller01;
	private GameObject dummyHighlightZebTeller02;
	private GameObject dummyHighlightZebTeller03;
	private GameObject dummyHighlightZebTeller04;
	private GameObject dummyHighlightZebTeller05;
	private GameObject dummyHighlightZebTeller06;
	private GameObject dummyHighlightZebSafebox;

	public bool zebraFinishedMeercat01 = false;
	public bool zebraFinishedMeercat02 = false;
	public bool zebraFinishedMeercat03 = false;
	public bool zebraFinishedMeercat04 = false;
	public bool zebraFinishedRabbit01 = false;
	public bool zebraFinishedRabbit02 = false;
	public bool zebraFinishedRabbit03 = false;
	public bool zebraFinishedRabbit04 = false;
	public bool zebraFinishedTeller01 = false;
	public bool zebraFinishedTeller02 = false;
	public bool zebraFinishedTeller03 = false;
	public bool zebraFinishedTeller04 = false;
	public bool zebraFinishedTeller05 = false;
	public bool zebraFinishedTeller06 = false;
	public bool zebraFinishedSafebox = false;

	private GameObject moneyTextMeercat01;
	private GameObject moneyTextMeercat02;
	private GameObject moneyTextMeercat03;
	private GameObject moneyTextMeercat04;
	private GameObject moneyTextRabbit01;
	private GameObject moneyTextRabbit02;
	private GameObject moneyTextRabbit03;
	private GameObject moneyTextRabbit04;
	private GameObject moneyTextTeller01;
	private GameObject moneyTextTeller02;
	private GameObject moneyTextTeller03;
	private GameObject moneyTextTeller04;
	private GameObject moneyTextTeller05;
	private GameObject moneyTextTeller06;
	private GameObject moneyTextSafebox;

	GameObject timerM1_10secondsObject;
	GameObject timerM2_10secondsObject;
	GameObject timerM3_10secondsObject;
	GameObject timerM4_10secondsObject;
	GameObject timerR1_10secondsObject;
	GameObject timerR2_10secondsObject;
	GameObject timerR3_10secondsObject;
	GameObject timerR4_10secondsObject;
	GameObject timerT1_10secondsObject;
	GameObject timerT2_10secondsObject;
	GameObject timerT3_10secondsObject;
	GameObject timerT4_10secondsObject;
	GameObject timerT5_10secondsObject;
	GameObject timerT6_10secondsObject;
	GameObject timerSB_10secondsObject;
	
	private GameObject moneyTeller01;
	private GameObject moneyTeller02;
	private GameObject moneyTeller03;
	private GameObject moneyTeller04;
	private GameObject moneyTeller05;
	private GameObject moneyTeller06;
	private GameObject moneySafebox;

	gameScore_Level_05 scoreMoney;

	Animator anim;
	
	void Start () 
	{
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		highlightZebMeercat04 = GameObject.Find ("highlightZebMeercat04");
		highlightZebRabbit01 = GameObject.Find ("highlightZebRabbit01");
		highlightZebRabbit02 = GameObject.Find ("highlightZebRabbit02");
		highlightZebRabbit03 = GameObject.Find ("highlightZebRabbit03");
		highlightZebRabbit04 = GameObject.Find ("highlightZebRabbit04");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller02 = GameObject.Find ("highlightZebTeller02");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		highlightZebTeller04 = GameObject.Find ("highlightZebTeller04");
		highlightZebTeller05 = GameObject.Find ("highlightZebTeller05");
		highlightZebTeller06 = GameObject.Find ("highlightZebTeller06");
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");

		dummyHighlightZebMeercat01 = GameObject.Find ("dummyHighlightZebMeercat01");
		dummyHighlightZebMeercat02 = GameObject.Find ("dummyHighlightZebMeercat02");
		dummyHighlightZebMeercat03 = GameObject.Find ("dummyHighlightZebMeercat03");
		dummyHighlightZebMeercat04 = GameObject.Find ("dummyHighlightZebMeercat04");
		dummyHighlightZebRabbit01 = GameObject.Find ("dummyHighlightZebRabbit01");
		dummyHighlightZebRabbit02 = GameObject.Find ("dummyHighlightZebRabbit02");
		dummyHighlightZebRabbit03 = GameObject.Find ("dummyHighlightZebRabbit03");
		dummyHighlightZebRabbit04 = GameObject.Find ("dummyHighlightZebRabbit04");
		dummyHighlightZebTeller01 = GameObject.Find ("dummyHighlightZebTeller01");
		dummyHighlightZebTeller02 = GameObject.Find ("dummyHighlightZebTeller02");
		dummyHighlightZebTeller03 = GameObject.Find ("dummyHighlightZebTeller03");
		dummyHighlightZebTeller04 = GameObject.Find ("dummyHighlightZebTeller04");
		dummyHighlightZebTeller05 = GameObject.Find ("dummyHighlightZebTeller05");
		dummyHighlightZebTeller06 = GameObject.Find ("dummyHighlightZebTeller06");
		dummyHighlightZebSafebox = GameObject.Find ("dummyHighlightZebSafebox");

		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		moneyTextMeercat02 = GameObject.Find ("moneyTextMeercat02");
		moneyTextMeercat03 = GameObject.Find ("moneyTextMeercat03");
		moneyTextMeercat04 = GameObject.Find ("moneyTextMeercat04");
		moneyTextRabbit01 = GameObject.Find ("moneyTextRabbit01");
		moneyTextRabbit02 = GameObject.Find ("moneyTextRabbit02");
		moneyTextRabbit03 = GameObject.Find ("moneyTextRabbit03");
		moneyTextRabbit04 = GameObject.Find ("moneyTextRabbit04");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		moneyTextTeller02 = GameObject.Find ("moneyTextTeller02");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		moneyTextTeller04 = GameObject.Find ("moneyTextTeller04");
		moneyTextTeller05 = GameObject.Find ("moneyTextTeller05");
		moneyTextTeller06 = GameObject.Find ("moneyTextTeller06");
		moneyTextSafebox = GameObject.Find("moneyTextSafebox");
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller02 = GameObject.Find ("moneyTeller02");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		moneyTeller04 = GameObject.Find ("moneyTeller04");
		moneyTeller05 = GameObject.Find ("moneyTeller05");
		moneyTeller06 = GameObject.Find ("moneyTeller06");
		moneySafebox = GameObject.Find ("moneySafebox");

		zebra = GameObject.Find ("zebra"); 
		zebraScript = GameObject.Find("zebra").GetComponent<zebra_Level_05>();

		scoreMoney = GameObject.Find("scoreGUItext").GetComponent<gameScore_Level_05>();
		
		timerM1_10secondsObject = GameObject.Find("timerM1_10seconds");
		timerM2_10secondsObject = GameObject.Find("timerM2_10seconds");
		timerM3_10secondsObject = GameObject.Find("timerM3_10seconds");
		timerM4_10secondsObject = GameObject.Find("timerM4_10seconds");
		timerR1_10secondsObject = GameObject.Find("timerR1_10seconds");
		timerR2_10secondsObject = GameObject.Find("timerR2_10seconds");
		timerR3_10secondsObject = GameObject.Find("timerR3_10seconds");
		timerR4_10secondsObject = GameObject.Find("timerR4_10seconds");
		timerT1_10secondsObject = GameObject.Find("timerT1_10seconds");
		timerT2_10secondsObject = GameObject.Find("timerT2_10seconds");
		timerT3_10secondsObject = GameObject.Find("timerT3_10seconds");
		timerT4_10secondsObject = GameObject.Find("timerT4_10seconds");
		timerT5_10secondsObject = GameObject.Find("timerT5_10seconds");
		timerT6_10secondsObject = GameObject.Find("timerT6_10seconds");
		timerSB_10secondsObject = GameObject.Find("timerSB_10seconds");
		
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
