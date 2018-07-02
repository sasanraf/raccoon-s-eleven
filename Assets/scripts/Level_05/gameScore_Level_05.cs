using UnityEngine;
using System.Collections;

public class gameScore_Level_05 : MonoBehaviour
{

	int score = 0;
	public int totalScore = 0;
	int lastScore = 0;

	public int moneyRandomMeercat01;
	public int moneyRandomMeercat02;
	public int moneyRandomMeercat03;
	public int moneyRandomMeercat04;
	public int moneyRandomRabbit01;
	public int moneyRandomRabbit02;
	public int moneyRandomRabbit03;
	public int moneyRandomRabbit04;
	public int moneyRandomTeller01;
	public int moneyRandomTeller02;
	public int moneyRandomTeller03;
	public int moneyRandomTeller04;
	public int moneyRandomTeller05;
	public int moneyRandomTeller06;	
	public int moneyRandomSafebox;

	GameObject moneyMeercat01;
	GameObject moneyMeercat02;
	GameObject moneyMeercat03;
	GameObject moneyMeercat04;
	GameObject moneyRabbit01;
	GameObject moneyRabbit02;
	GameObject moneyRabbit03;
	GameObject moneyRabbit04;	
	GameObject moneyTeller01;
	GameObject moneyTeller02;
	GameObject moneyTeller03;
	GameObject moneyTeller04;
	GameObject moneyTeller05;
	GameObject moneyTeller06;	
	GameObject moneySafebox;

	GameObject highlightMeercat01;
	GameObject highlightMeercat02;
	GameObject highlightMeercat03;
	GameObject highlightMeercat04;
	GameObject highlighRabbit01;
	GameObject highlighRabbit02;
	GameObject highlighRabbit03;
	GameObject highlighRabbit04;	
	GameObject highlighTeller01;
	GameObject highlighTeller02;
	GameObject highlighTeller03;
	GameObject highlighTeller04;
	GameObject highlighTeller05;
	GameObject highlighTeller06;	
	GameObject highlighSafebox;

	GameObject rhino;
	GameObject rhinoDummy;
	GameObject highlightZebSafebox;

	GameObject scoreBG;
	public int totalLevelMoney;

	// can not access the var if just add 'public int lastLevelScore = PlayerPrefs.GetInt("Player Score");' in void start
	public int lastLevelScore;

	zebra_Level_05 zebraScript;

	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;
	
	GameObject camera;

	// Use this for initialization
	void Start () 
	{

		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");

		rhino = GameObject.Find ("rhino");
		rhinoDummy = GameObject.Find ("rhinoDummy");
		highlightZebSafebox  = GameObject.Find ("highlightZebSafebox");

		//total score from previews lavels 
		lastLevelScore = PlayerPrefs.GetInt("Player Score");

		zebraScript = GameObject.Find ("zebra").GetComponent<zebra_Level_05>();
		zebraScript.moneyDone.Play();

		totalScore = totalScore + lastLevelScore;
		guiText.text = ("$" + totalScore.ToString());

		moneyRandomMeercat01 = Random.Range(50, 250);
		moneyRandomMeercat02 = Random.Range(50, 250);
		moneyRandomMeercat03 = Random.Range(50, 250);
		moneyRandomMeercat04 = Random.Range(50, 250);
		moneyRandomRabbit01 = Random.Range(500, 2000);
		moneyRandomRabbit02 = Random.Range(500, 2000);
		moneyRandomRabbit03 = Random.Range(500, 2000);
		moneyRandomRabbit04 = Random.Range(500, 2000);		
		moneyRandomTeller01 = Random.Range(2500, 3500);
		moneyRandomTeller02 = Random.Range(2500, 3500);
		moneyRandomTeller03 = Random.Range(2500, 3500);
		moneyRandomTeller04 = Random.Range(2500, 3500);
		moneyRandomTeller05 = Random.Range(2500, 3500);
		moneyRandomTeller06 = Random.Range(2500, 3500);	
		moneyRandomSafebox = Random.Range(10000, 15000);

		totalLevelMoney = moneyRandomMeercat01 + moneyRandomMeercat02 + moneyRandomMeercat03 + moneyRandomMeercat04 
			+ moneyRandomTeller01 + moneyRandomTeller02 +moneyRandomTeller03 + moneyRandomTeller04 + moneyRandomTeller05 + moneyRandomTeller06 + 
				moneyRandomRabbit01 + moneyRandomRabbit02 + moneyRandomRabbit03 + moneyRandomRabbit04 +moneyRandomSafebox;

		highlightMeercat01 = GameObject.Find ("highlightMonMeercat01");
		highlightMeercat02 = GameObject.Find ("highlightMonMeercat02");
		highlightMeercat03 = GameObject.Find ("highlightMonMeercat03");
		highlightMeercat04 = GameObject.Find ("highlightMonMeercat04");
		highlighRabbit01 = GameObject.Find ("highlightMonRabbit01");
		highlighRabbit02 = GameObject.Find ("highlightMonRabbit02");
		highlighRabbit03 = GameObject.Find ("highlightMonRabbit03");
		highlighRabbit04 = GameObject.Find ("highlightMonRabbit04");		
		highlighTeller01 = GameObject.Find ("highlightMonTeller01");
		highlighTeller02 = GameObject.Find ("highlightMonTeller02");
		highlighTeller03 = GameObject.Find ("highlightMonTeller03");
		highlighTeller04 = GameObject.Find ("highlightMonTeller04");
		highlighTeller05 = GameObject.Find ("highlightMonTeller05");
		highlighTeller06 = GameObject.Find ("highlightMonTeller06");		
		highlighSafebox = GameObject.Find ("highlightRhinoSafebox");

		moneyMeercat01 = GameObject.Find("moneyTextMeercat01");
		moneyMeercat02 = GameObject.Find("moneyTextMeercat02");
		moneyMeercat03 = GameObject.Find("moneyTextMeercat03");
		moneyMeercat04 = GameObject.Find("moneyTextMeercat04");
		moneyRabbit01 = GameObject.Find("moneyTextRabbit01");
		moneyRabbit02 = GameObject.Find("moneyTextRabbit02");
		moneyRabbit03 = GameObject.Find("moneyTextRabbit03");
		moneyRabbit04 = GameObject.Find("moneyTextRabbit04");	
		moneyTeller01 = GameObject.Find("moneyTextTeller01");
		moneyTeller02 = GameObject.Find("moneyTextTeller02");
		moneyTeller03 = GameObject.Find("moneyTextTeller03");
		moneyTeller04 = GameObject.Find("moneyTextTeller04");
		moneyTeller05 = GameObject.Find("moneyTextTeller05");
		moneyTeller06 = GameObject.Find("moneyTextTeller06");	
		moneySafebox = GameObject.Find("moneyTextSafebox");

		moneyMeercat01.guiText.enabled = true;
		moneyMeercat02.guiText.enabled = true;
		moneyMeercat03.guiText.enabled = true;
		moneyMeercat04.guiText.enabled = false;
		moneyRabbit01.guiText.enabled = true;
		moneyRabbit02.guiText.enabled = false;
		moneyRabbit03.guiText.enabled = false;
		moneyRabbit04.guiText.enabled = false;
		moneyTeller01.guiText.enabled = true;
		moneyTeller02.guiText.enabled = true;
		moneyTeller03.guiText.enabled = true;
		moneyTeller04.guiText.enabled = false;
		moneyTeller05.guiText.enabled = false;
		moneyTeller06.guiText.enabled = false;
		moneySafebox.guiText.enabled = false;

		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;

		moneyMeercat01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat04.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit04.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller04.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller05.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller06.guiText.fontSize = (int) (Screen.width * 0.04f);
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
			
			moneyMeercat01.transform.position = new Vector3(moneyMeercat01_x ,moneyMeercat01_y,0);
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

		if (highlightMeercat04 && moneyMeercat04)
		{
			Vector3 highlightMonMeercat4Pos = Camera.main.WorldToScreenPoint (highlightMeercat04.transform.position);
			float moneyMeercat04_x = (highlightMonMeercat4Pos.x/screenWidthX);
			float moneyMeercat04_y = (highlightMonMeercat4Pos.y/screenHeightY);
			
			moneyMeercat04.transform.position = new Vector3(moneyMeercat04_x-1,moneyMeercat04_y,0);
			moneyMeercat04.guiText.text = ("$" + moneyRandomMeercat04.ToString());
		}

		if (highlighRabbit01 && moneyRabbit01)
		{
			Vector3 highlightMonRabbit1Pos = Camera.main.WorldToScreenPoint (highlighRabbit01.transform.position);
			float moneyRabbit01_x = (highlightMonRabbit1Pos.x/screenWidthX);
			float moneyRabbit01_y = (highlightMonRabbit1Pos.y/screenHeightY);
			
			moneyRabbit01.transform.position = new Vector3(moneyRabbit01_x ,moneyRabbit01_y,0);
			moneyRabbit01.guiText.text = ("$" + moneyRandomRabbit01.ToString());
			
		}

		if (highlighRabbit02 && moneyRabbit02)
		{
			Vector3 highlightMonRabbit2Pos = Camera.main.WorldToScreenPoint (highlighRabbit02.transform.position);
			float moneyRabbit02_x = (highlightMonRabbit2Pos.x/screenWidthX);
			float moneyRabbit02_y = (highlightMonRabbit2Pos.y/screenHeightY);
			
			moneyRabbit02.transform.position = new Vector3(moneyRabbit02_x-1 ,moneyRabbit02_y,0);
			moneyRabbit02.guiText.text = ("$" + moneyRandomRabbit02.ToString());
			
		}

		if (highlighRabbit03 && moneyRabbit03)
		{
			Vector3 highlightMonRabbit3Pos = Camera.main.WorldToScreenPoint (highlighRabbit03.transform.position);
			float moneyRabbit03_x = (highlightMonRabbit3Pos.x/screenWidthX);
			float moneyRabbit03_y = (highlightMonRabbit3Pos.y/screenHeightY);
			
			moneyRabbit03.transform.position = new Vector3(moneyRabbit03_x-1 ,moneyRabbit03_y,0);
			moneyRabbit03.guiText.text = ("$" + moneyRandomRabbit03.ToString());
			
		}
		
		if (highlighRabbit04 && moneyRabbit04)
		{
			Vector3 highlightMonRabbit4Pos = Camera.main.WorldToScreenPoint (highlighRabbit04.transform.position);
			float moneyRabbit04_x = (highlightMonRabbit4Pos.x/screenWidthX);
			float moneyRabbit04_y = (highlightMonRabbit4Pos.y/screenHeightY);
			
			moneyRabbit04.transform.position = new Vector3(moneyRabbit04_x-1 ,moneyRabbit04_y,0);
			moneyRabbit04.guiText.text = ("$" + moneyRandomRabbit04.ToString());
			
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

		if (highlighTeller04 && moneyTeller04)
		{
			Vector3 highlightMonTeller4Pos = Camera.main.WorldToScreenPoint (highlighTeller04.transform.position);
			float moneyTeller04_x = (highlightMonTeller4Pos.x/screenWidthX);
			float moneyTeller04_y = (highlightMonTeller4Pos.y/screenHeightY);
			
			moneyTeller04.transform.position = new Vector3(moneyTeller04_x-1,moneyTeller04_y,0);
			moneyTeller04.guiText.text = ("$" + moneyRandomTeller04.ToString());
		}

		if (highlighTeller05 && moneyTeller05)
		{
			Vector3 highlightMonTeller5Pos = Camera.main.WorldToScreenPoint (highlighTeller05.transform.position);
			float moneyTeller05_x = (highlightMonTeller5Pos.x/screenWidthX);
			float moneyTeller05_y = (highlightMonTeller5Pos.y/screenHeightY);
			
			moneyTeller05.transform.position = new Vector3(moneyTeller05_x-1,moneyTeller05_y,0);
			moneyTeller05.guiText.text = ("$" + moneyRandomTeller05.ToString());
		}
		
		if (highlighTeller06 && moneyTeller06)
		{
			Vector3 highlightMonTeller6Pos = Camera.main.WorldToScreenPoint (highlighTeller06.transform.position);
			float moneyTeller06_x = (highlightMonTeller6Pos.x/screenWidthX);
			float moneyTeller06_y = (highlightMonTeller6Pos.y/screenHeightY);
			
			moneyTeller06.transform.position = new Vector3(moneyTeller06_x-1,moneyTeller06_y,0);
			moneyTeller06.guiText.text = ("$" + moneyRandomTeller06.ToString());
		}

		if (highlighSafebox && moneySafebox)
		{
			Vector3 highlightMonSafeboxPos = Camera.main.WorldToScreenPoint (highlighSafebox.transform.position);
			float moneySafebox_x = (highlightMonSafeboxPos.x/screenWidthX);
			float moneySafebox_y = (highlightMonSafeboxPos.y/screenHeightY);
			
			moneySafebox.transform.position = new Vector3(moneySafebox_x-1,moneySafebox_y,0);
			moneySafebox.guiText.text = ("$" + moneyRandomSafebox.ToString());
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		//guiText.text = ("$" + totalScore.ToString());
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
