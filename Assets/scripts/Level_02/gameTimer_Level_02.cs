using UnityEngine;
using System.Collections;

public class gameTimer_Level_02 : MonoBehaviour 
{

	float levelTimer = 60f;
	string currentLevelName;

	private GameObject 	highlightZebMeercat01;
	private GameObject 	highlightZebMeercat02;
	private GameObject 	highlightZebMeercat03;
	private GameObject 	highlightZebTeller01;
	private GameObject 	highlightZebTeller03;

	private GameObject 	timerObjectZebra;

	GameObject timerBGObject;

	GameObject moneyTextMeercat01;
	GameObject moneyTextMeercat02;
	GameObject moneyTextMeercat03;
	GameObject moneyTextTeller01;
	GameObject moneyTextTeller03;
	GameObject scoreGUItext;
	GameObject timerGUIText;

	private GameObject zebra;
	private GameObject zebraDummy;

	gameScore_Level_02 score;
	endResult endResultScript;

	int starsCount;

	pigEvil pigEvilScript;
	
	void Start () 
	{
		pigEvilScript = GameObject.Find ("pigEvil").GetComponent<pigEvil>();

		currentLevelName = Application.loadedLevelName;	
		guiText.text = ("Time left: " + levelTimer.ToString("f0"));
		
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");

		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		moneyTextMeercat02 = GameObject.Find ("moneyTextMeercat02");
		moneyTextMeercat03 = GameObject.Find ("moneyTextMeercat03");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		scoreGUItext = GameObject.Find ("scoreGUItext");
		timerGUIText = GameObject.Find ("timerGUIText");

		timerBGObject = GameObject.Find ("timerBG");

		timerObjectZebra = GameObject.Find ("timerObjectZebra");

		score = GameObject.Find ("scoreGUItext").GetComponent<gameScore_Level_02>();

		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;
		Vector3 timerBGPos = Camera.main.WorldToScreenPoint (timerBGObject.transform.position);
		float timerPos_x = (timerBGPos.x/screenWidthX);
		float timerPos_y = (timerBGPos.y/screenHeightY);

		this.transform.position = new Vector3(timerPos_x,timerPos_y-0.01f,0);
		
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

		if (levelTimer <= 1 || (!highlightZebMeercat01 && !highlightZebMeercat02 && !highlightZebMeercat03 && !highlightZebTeller01 && !highlightZebTeller03 && timerObjectZebra.renderer.enabled==false))
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
					PlayerPrefs.SetInt("starsReg01_Bank02", 1);
					starsCount = 1;

				}
				if ((score.totalScore - score.lastLevelScore) >= secondStarRange && (score.totalScore - score.lastLevelScore) < thirdStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank02", 2);
					starsCount = 2;
				}
				if ((score.totalScore - score.lastLevelScore) > thirdStarRange)
				{
					PlayerPrefs.SetInt("starsReg01_Bank02", 3);
					starsCount = 3;
				}
				
				PlayerPrefs.SetString("bankReg01_Bank03", "unlocked");

				Destroy(moneyTextMeercat01);
				Destroy(moneyTextMeercat02);
				Destroy(moneyTextMeercat03);
				Destroy(moneyTextTeller01);
				Destroy(moneyTextTeller03);
				Destroy(timerGUIText);

				endResultScript.showResult(starsCount);
			}
			
			else 
			{
				audio.Stop();
				guiText.enabled = false;
				pigEvilScript.pigLaughing();
			}

		}
	}

}

