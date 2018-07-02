using UnityEngine;
using System.Collections;

public class gameTimer_Level_10 : MonoBehaviour 
{

	float levelTimer = 99f;
	string currentLevelName;
	
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
	
	GameObject scoreGUItext;
	GameObject timerGUIText;

	private GameObject 	timerObjectZebra;

	GameObject timerBGObject;
	
	private GameObject zebra;
	private GameObject zebraDummy;

	gameScore_Level_10 score;

	endResult endResultScript;
	int starsCount;

	timerZebra_Level_10 zebraSafeBoxCheck;

	pigEvil_level_10 pigEvilScript;

	GameObject monkey;
	GameObject rhino;
	GameObject dog;
	
	void Start () 
	{
		monkey = GameObject.Find ("monkey");
		rhino = GameObject.Find ("rhino");
		dog = GameObject.Find ("dog");

		pigEvilScript = GameObject.Find ("pigEvil").GetComponent<pigEvil_level_10>();

		zebraSafeBoxCheck = GameObject.Find ("timerObjectZebra").GetComponent<timerZebra_Level_10>();

		currentLevelName = Application.loadedLevelName;	
		guiText.text = ("Time left: " + levelTimer.ToString("f0"));
		
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
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");
		highlightZebSafebox03 = GameObject.Find ("highlightZebSafebox03");
		
		scoreGUItext = GameObject.Find ("scoreGUItext");
		timerGUIText = GameObject.Find ("timerGUIText");

		score = GameObject.Find ("scoreGUItext").GetComponent<gameScore_Level_10>();

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
	
		if (levelTimer <= 1 || !zebra || (!highlightZebMeercat01 && !highlightZebMeercat02 && !highlightZebMeercat03 && !highlightZebMeercat04
								&& !highlightZebMeercat05 && !highlightZebMeercat06
		                        && !highlightZebTeller01 && !highlightZebTeller02 && !highlightZebTeller03 && !highlightZebTeller04 
								&& !highlightZebTeller05 && !highlightZebTeller06 && !highlightZebTeller07 && !highlightZebTeller08
								&& !highlightZebTeller09 && !highlightZebTeller10 
		                        && !highlightZebRabbit01 && !highlightZebRabbit02 && !highlightZebRabbit03 && !highlightZebRabbit04 && !highlightZebRabbit05 
								&& !highlightZebSafebox && !highlightZebSafebox02 && !highlightZebSafebox03
								&& timerObjectZebra.renderer.enabled == false))
		{

			PlayerPrefs.SetInt("Player Score", score.totalScore);
			if (dog)
			{
				Destroy (dog);
			}
			// calculation for stars. total money divid  by 10 then first star 5/10, second 7/10, third bigger than 8/10
			int perMoneyShare = (score.totalLevelMoney)/10;
			int firstStarRange = 5*perMoneyShare;
			int secondStarRange = 7*perMoneyShare;
			int thirdStarRange = 8*perMoneyShare;
			
			if ((score.totalScore - score.lastLevelScore) >= firstStarRange)
			{
				if ((score.totalScore - score.lastLevelScore) >= firstStarRange && (score.totalScore - score.lastLevelScore) < secondStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank10", 1);
					starsCount = 1;
				}
				if ((score.totalScore - score.lastLevelScore) >= secondStarRange && (score.totalScore - score.lastLevelScore) < thirdStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank10", 2);
					starsCount = 2;
				}
				if ((score.totalScore - score.lastLevelScore) > thirdStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank10", 3);
					starsCount = 3;
				}
				
				PlayerPrefs.SetString("bankReg01_Bank10", "unlocked");
				
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

