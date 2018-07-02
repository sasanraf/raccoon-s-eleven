using UnityEngine;
using System.Collections;

public class gameScore_Level_10 : MonoBehaviour
{

	int score = 0;
	public int totalScore = 0;
	int lastScore = 0;

	public int moneyRandomMeercat01;
	public int moneyRandomMeercat02;
	public int moneyRandomMeercat03;
	public int moneyRandomMeercat04;
	public int moneyRandomMeercat05;
	public int moneyRandomMeercat06;
	public int moneyRandomRabbit01;
	public int moneyRandomRabbit02;
	public int moneyRandomRabbit03;
	public int moneyRandomRabbit04;
	public int moneyRandomRabbit05;
	public int moneyRandomTeller01;
	public int moneyRandomTeller02;
	public int moneyRandomTeller03;
	public int moneyRandomTeller04;
	public int moneyRandomTeller05;
	public int moneyRandomTeller06;
	public int moneyRandomTeller07;
	public int moneyRandomTeller08;
	public int moneyRandomTeller09;
	public int moneyRandomTeller10;
	public int moneyRandomSafebox;
	public int moneyRandomSafebox02;
	public int moneyRandomSafebox03;
	
	GameObject moneyMeercat01;
	GameObject moneyMeercat02;
	GameObject moneyMeercat03;
	GameObject moneyMeercat04;
	GameObject moneyMeercat05;
	GameObject moneyMeercat06;
	GameObject moneyRabbit01;
	GameObject moneyRabbit02;
	GameObject moneyRabbit03;
	GameObject moneyRabbit04;	
	GameObject moneyRabbit05;
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
	
	GameObject highlightMeercat01;
	GameObject highlightMeercat02;
	GameObject highlightMeercat03;
	GameObject highlightMeercat04;
	GameObject highlightMeercat05;
	GameObject highlightMeercat06;
	GameObject highlighRabbit01;
	GameObject highlighRabbit02;
	GameObject highlighRabbit03;
	GameObject highlighRabbit04;
	GameObject highlighRabbit05;	
	GameObject highlighTeller01;
	GameObject highlighTeller02;
	GameObject highlighTeller03;
	GameObject highlighTeller04;	
	GameObject highlighTeller05;
	GameObject highlighTeller06;
	GameObject highlighTeller07;
	GameObject highlighTeller08;
	GameObject highlighTeller09;
	GameObject highlighTeller10;
	GameObject highlighSafebox;
	GameObject highlighSafebox02;
	GameObject highlighSafebox03;
	
	GameObject rhino;
	GameObject rhinoDummy;
	GameObject highlightZebSafebox;

	GameObject scoreBG;
	public int totalLevelMoney;

	// can not access the var if just add 'public int lastLevelScore = PlayerPrefs.GetInt("Player Score");' in void start
	public int lastLevelScore;

	zebra_Level_10 zebraScript;

	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;
	
	GameObject camera;
	Camera cameraScript;


	// Use this for initialization
	void Start () 
	{
		cameraScript = GameObject.Find ("Main Camera").GetComponent<Camera>();
		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");

		rhino = GameObject.Find ("rhino");
		rhinoDummy = GameObject.Find ("rhinoDummy");
		highlightZebSafebox  = GameObject.Find ("highlightZebSafebox");

		//total score from previews lavels 
		lastLevelScore = PlayerPrefs.GetInt("Player Score");

		zebraScript = GameObject.Find ("zebra").GetComponent<zebra_Level_10>();
		zebraScript.moneyDone.Play();

		totalScore = totalScore + lastLevelScore;
		guiText.text = ("$" + totalScore.ToString());

		moneyRandomMeercat01 = PlayerPrefs.GetInt("moneyRandomMeercat01_level10");
		moneyRandomMeercat02 = PlayerPrefs.GetInt("moneyRandomMeercat02_level10");
		moneyRandomMeercat03 = PlayerPrefs.GetInt("moneyRandomMeercat03_level10");
		moneyRandomMeercat04 = PlayerPrefs.GetInt("moneyRandomMeercat04_level10");
		moneyRandomMeercat05 = PlayerPrefs.GetInt("moneyRandomMeercat05_level10");
		moneyRandomMeercat06 = PlayerPrefs.GetInt("moneyRandomMeercat06_level10");
		moneyRandomRabbit01 = PlayerPrefs.GetInt("moneyRandomRabbit01_level10");
		moneyRandomRabbit02 = PlayerPrefs.GetInt("moneyRandomRabbit02_level10");
		moneyRandomRabbit03 = PlayerPrefs.GetInt("moneyRandomRabbit03_level10");
		moneyRandomRabbit04 = PlayerPrefs.GetInt("moneyRandomRabbit04_level10");
		moneyRandomRabbit05 = PlayerPrefs.GetInt("moneyRandomRabbit05_level10");
		moneyRandomTeller01 = PlayerPrefs.GetInt("moneyRandomTeller01_level10");
		moneyRandomTeller02 = PlayerPrefs.GetInt("moneyRandomTeller02_level10");
		moneyRandomTeller03 = PlayerPrefs.GetInt("moneyRandomTeller03_level10");
		moneyRandomTeller04 = PlayerPrefs.GetInt("moneyRandomTeller04_level10");
		moneyRandomTeller05 = PlayerPrefs.GetInt("moneyRandomTeller05_level10");
		moneyRandomTeller06 = PlayerPrefs.GetInt("moneyRandomTeller06_level10");
		moneyRandomTeller07 = PlayerPrefs.GetInt("moneyRandomTeller07_level10");
		moneyRandomTeller08 = PlayerPrefs.GetInt("moneyRandomTeller08_level10");
		moneyRandomTeller09 = PlayerPrefs.GetInt("moneyRandomTeller09_level10");
		moneyRandomTeller10 = PlayerPrefs.GetInt("moneyRandomTeller10_level10");
		moneyRandomSafebox = PlayerPrefs.GetInt("moneyRandomSafebox_level10");
		moneyRandomSafebox02 =  PlayerPrefs.GetInt("moneyRandomSafebox02_level10");
		moneyRandomSafebox03 =  PlayerPrefs.GetInt("moneyRandomSafebox03_level10");


		totalLevelMoney = moneyRandomMeercat01 + moneyRandomMeercat02 + moneyRandomMeercat03 
			+ moneyRandomMeercat04 + moneyRandomMeercat05 + moneyRandomMeercat06
			+ moneyRandomTeller01 + moneyRandomTeller02 +moneyRandomTeller03 + moneyRandomTeller04 
			+ moneyRandomTeller05 + moneyRandomTeller06 +moneyRandomTeller07 + moneyRandomTeller08 
			+ moneyRandomTeller09 + moneyRandomTeller10 + 
			moneyRandomRabbit01 + moneyRandomRabbit02 + moneyRandomRabbit03 + moneyRandomRabbit04 + moneyRandomRabbit05 +
			moneyRandomSafebox + moneyRandomSafebox02 + moneyRandomSafebox03; 

		//texts layer is 11 but not timer and score
		cameraScript.cullingMask = ~(1 << 11);


		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;


		scoreBG = GameObject.Find ("scoreBG");
		
		Vector3 scoreBGPos = Camera.main.WorldToScreenPoint (scoreBG.transform.position);
		float scoreBGPos_x = (scoreBGPos.x/screenWidthX);
		float scoreBGPos_y = (scoreBGPos.y/screenHeightY);

		this.transform.position = new Vector3(scoreBGPos_x,scoreBGPos_y,0);

		guiText.fontSize = (int) (Screen.width * 0.04f);
			
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
