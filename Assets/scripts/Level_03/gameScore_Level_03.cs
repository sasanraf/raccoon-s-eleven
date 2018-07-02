using UnityEngine;
using System.Collections;

public class gameScore_Level_03 : MonoBehaviour
{

	int score = 0;
	public int totalScore = 0;
	int lastScore = 0;

	public int moneyRandomMeercat01;
	public int moneyRandomMeercat02;
	public int moneyRandomMeercat03;
	public int moneyRandomRabbit01;
	public int moneyRandomTeller01;
	public int moneyRandomTeller02;
	public int moneyRandomTeller03;
	public int moneyRandomSafebox;

	GameObject moneyMeercat01;
	GameObject moneyMeercat02;
	GameObject moneyMeercat03;
	GameObject moneyRabbit01;
	GameObject moneyTeller01;
	GameObject moneyTeller02;
	GameObject moneyTeller03;
	GameObject moneySafebox;

	GameObject highlightMeercat01;
	GameObject highlightMeercat02;
	GameObject highlightMeercat03;
	GameObject highlighRabbit01;
	GameObject highlighTeller01;
	GameObject highlighTeller02;
	GameObject highlighTeller03;
	GameObject highlighSafebox;

	GameObject rhino;
	GameObject rhinoDummy;
	GameObject highlightZebSafebox;

	GameObject scoreBG;
	public int totalLevelMoney;

	// can not access the var if just add 'public int lastLevelScore = PlayerPrefs.GetInt("Player Score");' in void start
	public int lastLevelScore;

	zebra_Level_03 zebraScript;

	// Use this for initialization
	void Start () 
	{
		rhino = GameObject.Find ("rhino");
		rhinoDummy = GameObject.Find ("rhinoDummy");
		highlightZebSafebox  = GameObject.Find ("highlightZebSafebox");

		//total score from previews lavels 
		lastLevelScore = PlayerPrefs.GetInt("Player Score");

		zebraScript = GameObject.Find ("zebra").GetComponent<zebra_Level_03>();
		zebraScript.moneyDone.Play();

		totalScore = totalScore + lastLevelScore;
		guiText.text = ("$" + totalScore.ToString());

		moneyRandomMeercat01 = Random.Range(50, 250);
		moneyRandomMeercat02 = Random.Range(50, 250);
		moneyRandomMeercat03 = Random.Range(50, 250);
		moneyRandomRabbit01 = Random.Range(500, 2000);
		moneyRandomTeller01 = Random.Range(2500, 3500);
		moneyRandomTeller02 = Random.Range(2500, 3500);
		moneyRandomTeller03 = Random.Range(2500, 3500);
		moneyRandomSafebox = Random.Range(10000, 15000);

		totalLevelMoney = moneyRandomMeercat01 + moneyRandomMeercat02 + moneyRandomMeercat03 
			+ moneyRandomTeller01 + moneyRandomTeller02 +moneyRandomTeller03 + moneyRandomRabbit01 + moneyRandomSafebox;

		highlightMeercat01 = GameObject.Find ("highlightMonMeercat01");
		highlightMeercat02 = GameObject.Find ("highlightMonMeercat02");
		highlightMeercat03 = GameObject.Find ("highlightMonMeercat03");
		highlighRabbit01 = GameObject.Find ("highlightMonRabbit01");
		highlighTeller01 = GameObject.Find ("highlightMonTeller01");
		highlighTeller02 = GameObject.Find ("highlightMonTeller02");
		highlighTeller03 = GameObject.Find ("highlightMonTeller03");
		highlighSafebox = GameObject.Find ("highlightRhinoSafebox");

		moneyMeercat01 = GameObject.Find("moneyTextMeercat01");
		moneyMeercat02 = GameObject.Find("moneyTextMeercat02");
		moneyMeercat03 = GameObject.Find("moneyTextMeercat03");
		moneyRabbit01 = GameObject.Find("moneyTextRabbit01");
		moneyTeller01 = GameObject.Find("moneyTextTeller01");
		moneyTeller02 = GameObject.Find("moneyTextTeller02");
		moneyTeller03 = GameObject.Find("moneyTextTeller03");
		moneySafebox = GameObject.Find("moneyTextSafebox");

		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;

		moneyMeercat01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneySafebox.guiText.fontSize = (int) (Screen.width * 0.04f);
		guiText.fontSize = (int) (Screen.width * 0.04f);


		scoreBG = GameObject.Find ("scoreBG");
		
		Vector3 scoreBGPos = Camera.main.WorldToScreenPoint (scoreBG.transform.position);
		float scoreBGPos_x = (scoreBGPos.x/screenWidthX);
		float scoreBGPos_y = (scoreBGPos.y/screenHeightY);

		this.transform.position = new Vector3(scoreBGPos_x,scoreBGPos_y,0);

		if (highlightMeercat01 && moneyMeercat01)
		{
		Vector3 highlightMonMeercat1Pos = Camera.main.WorldToScreenPoint (highlightMeercat01.transform.position);
 		float moneyMeercat01_x = (highlightMonMeercat1Pos.x/screenWidthX);
		float moneyMeercat01_y = (highlightMonMeercat1Pos.y/screenHeightY);
		
		moneyMeercat01.transform.position = new Vector3(moneyMeercat01_x,moneyMeercat01_y,0);
		moneyMeercat01.guiText.text = ("$" + moneyRandomMeercat01.ToString());
		}

		if (highlightMeercat02 && moneyMeercat02)
		{
		Vector3 highlightMonMeercat2Pos = Camera.main.WorldToScreenPoint (highlightMeercat02.transform.position);
		float moneyMeercat02_x = (highlightMonMeercat2Pos.x/screenWidthX);
		float moneyMeercat02_y = (highlightMonMeercat2Pos.y/screenHeightY);

		moneyMeercat02.transform.position = new Vector3(moneyMeercat02_x,moneyMeercat02_y,0);
		moneyMeercat02.guiText.text = ("$" + moneyRandomMeercat02.ToString());

		}

		if (highlightMeercat03 && moneyMeercat03)
		{
		Vector3 highlightMonMeercat3Pos = Camera.main.WorldToScreenPoint (highlightMeercat03.transform.position);
		float moneyMeercat03_x = (highlightMonMeercat3Pos.x/screenWidthX);
		float moneyMeercat03_y = (highlightMonMeercat3Pos.y/screenHeightY);

		moneyMeercat03.transform.position = new Vector3(moneyMeercat03_x,moneyMeercat03_y,0);
		moneyMeercat03.guiText.text = ("$" + moneyRandomMeercat03.ToString());

		}

		if (highlighRabbit01 && moneyRabbit01)
		{
			Vector3 highlightMonRabbit1Pos = Camera.main.WorldToScreenPoint (highlighRabbit01.transform.position);
			float moneyRabbit01_x = (highlightMonRabbit1Pos.x/screenWidthX);
			float moneyRabbit01_y = (highlightMonRabbit1Pos.y/screenHeightY);
			
			moneyRabbit01.transform.position = new Vector3(moneyRabbit01_x,moneyRabbit01_y,0);
			moneyRabbit01.guiText.text = ("$" + moneyRandomRabbit01.ToString());
			
		}

		if (highlighTeller01 && moneyTeller01)
		{
		Vector3 highlightMonTeller1Pos = Camera.main.WorldToScreenPoint (highlighTeller01.transform.position);
		float moneyTeller01_x = (highlightMonTeller1Pos.x/screenWidthX);
		float moneyTeller01_y = (highlightMonTeller1Pos.y/screenHeightY);
	
		moneyTeller01.transform.position = new Vector3(moneyTeller01_x,moneyTeller01_y,0);
		moneyTeller01.guiText.text = ("$" + moneyRandomTeller01.ToString());

		}

		if (highlighTeller02 && moneyTeller02)
		{
			Vector3 highlightMonTeller2Pos = Camera.main.WorldToScreenPoint (highlighTeller02.transform.position);
			float moneyTeller02_x = (highlightMonTeller2Pos.x/screenWidthX);
			float moneyTeller02_y = (highlightMonTeller2Pos.y/screenHeightY);
			
			moneyTeller02.transform.position = new Vector3(moneyTeller02_x,moneyTeller02_y,0);
			moneyTeller02.guiText.text = ("$" + moneyRandomTeller02.ToString());
			
		}

		if (highlighTeller03 && moneyTeller03)
		{
		Vector3 highlightMonTeller3Pos = Camera.main.WorldToScreenPoint (highlighTeller03.transform.position);
		float moneyTeller03_x = (highlightMonTeller3Pos.x/screenWidthX);
		float moneyTeller03_y = (highlightMonTeller3Pos.y/screenHeightY);
		
		moneyTeller03.transform.position = new Vector3(moneyTeller03_x,moneyTeller03_y,0);
		moneyTeller03.guiText.text = ("$" + moneyRandomTeller03.ToString());
		}

		if (highlighSafebox && moneySafebox)
		{
			Vector3 highlightMonSafeboxPos = Camera.main.WorldToScreenPoint (highlighSafebox.transform.position);
			float moneySafebox_x = (highlightMonSafeboxPos.x/screenWidthX);
			float moneySafebox_y = (highlightMonSafeboxPos.y/screenHeightY);
			
			moneySafebox.transform.position = new Vector3(moneySafebox_x,moneySafebox_y,0);
			moneySafebox.guiText.text = ("$" + moneyRandomSafebox.ToString());
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (lastScore != totalScore)
		{
			StartCoroutine(delayCounter());
		}
	}

	IEnumerator delayCounter() 
	{
		for (int scoreCounter = (totalScore-25); scoreCounter < (totalScore+1); scoreCounter++)
		{
			yield return new WaitForSeconds(.00001f);
			guiText.text = ("$" + scoreCounter.ToString());
		}
		lastScore = totalScore;

	}

	public void levelScore(int score)
	{
		totalScore += score;
	}

	public void levelFailMoneyBack()
	{
		totalScore = lastLevelScore;
	}

}
