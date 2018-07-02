using UnityEngine;
using System.Collections;

public class gameTimer_Level_05 : MonoBehaviour 
{

	float levelTimer = 60f;
	string currentLevelName;
	
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

	GameObject moneyTextMeercat01;
	GameObject moneyTextMeercat02;
	GameObject moneyTextMeercat03;
	GameObject moneyTextMeercat04;
	GameObject moneyTextRabbit01;
	GameObject moneyTextRabbit02;
	GameObject moneyTextRabbit03;
	GameObject moneyTextRabbit04;
	GameObject moneyTextTeller01;
	GameObject moneyTextTeller02;
	GameObject moneyTextTeller03;
	GameObject moneyTextTeller04;
	GameObject moneyTextTeller05;
	GameObject moneyTextTeller06;
	GameObject moneyTextSafebox;
	GameObject scoreGUItext;
	GameObject timerGUIText;

	private GameObject 	timerObjectZebra;

	GameObject timerBGObject;
	
	private GameObject zebra;
	private GameObject zebraDummy;

	gameScore_Level_05 score;

	endResult endResultScript;
	int starsCount;

	timerZebra_Level_05 zebraSafeBoxCheck;

	pigEvil pigEvilScript;

	GameObject monkey;
	GameObject rhino;
	
	void Start () 
	{
		monkey = GameObject.Find ("monkey");
		rhino = GameObject.Find ("rhino");

		pigEvilScript = GameObject.Find ("pigEvil").GetComponent<pigEvil>();

		zebraSafeBoxCheck = GameObject.Find ("timerObjectZebra").GetComponent<timerZebra_Level_05>();

		currentLevelName = Application.loadedLevelName;	
		guiText.text = ("Time left: " + levelTimer.ToString("f0"));
		
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
		moneyTextSafebox = GameObject.Find ("moneyTextSafebox");
		scoreGUItext = GameObject.Find ("scoreGUItext");
		timerGUIText = GameObject.Find ("timerGUIText");

		score = GameObject.Find ("scoreGUItext").GetComponent<gameScore_Level_05>();

		timerBGObject = GameObject.Find ("timerBG");

		timerObjectZebra = GameObject.Find ("timerObjectZebra");

		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;
		Vector3 timerBGPos = Camera.main.WorldToScreenPoint (timerBGObject.transform.position);
		float timerPos_x = (timerBGPos.x/screenWidthX);
		float timerPos_y = (timerBGPos.y/screenHeightY);

		this.transform.position = new Vector3(timerPos_x ,timerPos_y-0.01f, 0);
		
		zebra = GameObject.Find ("zebra"); 
		zebraDummy = GameObject.Find ("zebraDummy");

		endResultScript = GameObject.Find("endResult").GetComponent<endResult>();
		guiText.fontSize = (int) (Screen.width * 0.05f);
		
	}
	
	void Update () 
	{
		
		levelTimer -= Time.deltaTime;
		guiText.text = (levelTimer.ToString("f0"));

		if ((int)levelTimer == 10)
		{
			audio.Play();
		}
	
		if (levelTimer <= 1 || (!highlightZebMeercat01 && !highlightZebMeercat02 && !highlightZebMeercat03 && !highlightZebMeercat04 
		                        && !highlightZebTeller01 && !highlightZebTeller02 && !highlightZebTeller03 && !highlightZebTeller04 && !highlightZebTeller05 && !highlightZebTeller06   
		                        && !highlightZebRabbit01 && !highlightZebRabbit02 && !highlightZebRabbit03 && !highlightZebRabbit04 && !highlightZebSafebox && timerObjectZebra.renderer.enabled == false))
		{
			PlayerPrefs.SetInt("Player Score", score.totalScore);

			// calculation for stars. total money divid  by 10 then first star 5/10, second 7/10, third bigger than 8/10
			int perMoneyShare = (score.totalLevelMoney)/10;
			int firstStarRange = 5*perMoneyShare;
			int secondStarRange = 7*perMoneyShare;
			int thirdStarRange = 8*perMoneyShare;
			
			if ((score.totalScore - score.lastLevelScore) >= firstStarRange)
			{
				if ((score.totalScore - score.lastLevelScore) >= firstStarRange && (score.totalScore - score.lastLevelScore) < secondStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank05", 1);
					starsCount = 1;
				}
				if ((score.totalScore - score.lastLevelScore) >= secondStarRange && (score.totalScore - score.lastLevelScore) < thirdStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank05", 2);
					starsCount = 2;
				}
				if ((score.totalScore - score.lastLevelScore) > thirdStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank05", 3);
					starsCount = 3;
				}
				
				PlayerPrefs.SetString("bankReg01_Bank06", "unlocked");
				
				Destroy(moneyTextMeercat01);
				Destroy(moneyTextMeercat02);
				Destroy(moneyTextMeercat03);
				Destroy(moneyTextMeercat04);
				Destroy(moneyTextRabbit01);
				Destroy(moneyTextRabbit02);
				Destroy(moneyTextRabbit03);
				Destroy(moneyTextRabbit04);
				Destroy(moneyTextTeller01);
				Destroy(moneyTextTeller02);
				Destroy(moneyTextTeller03);
				Destroy(moneyTextTeller04);
				Destroy(moneyTextTeller05);
				Destroy(moneyTextTeller06);
				Destroy(moneyTextSafebox);
				Destroy(timerGUIText);

				if (monkey)
				{
					monkey.renderer.enabled = false;
				}
				if (zebra)
				{
					zebra.renderer.enabled = false;
				}
				if (rhino)
				{
					rhino.renderer.enabled = false;
				}
				
				endResultScript.showResult(starsCount);

			}
			else 
			{

				if (monkey)
				{
					monkey.renderer.enabled = false;
				}
				if (zebra)
				{
					zebra.renderer.enabled = false;
				}
				if (rhino)
				{
					rhino.renderer.enabled = false;
				}

				score.levelFailMoneyBack();
				audio.Stop();
				guiText.enabled = false;
				pigEvilScript.pigLaughing();
			}

		}
	}


}

