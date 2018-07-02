using UnityEngine;
using System.Collections;

public class gameScore_Level_09 : MonoBehaviour
{

	int score = 0;
	public int totalScore = 0;
	int lastScore = 0;

	public int moneyRandomMeercat01;
	public int moneyRandomRabbit01;
	public int moneyRandomRabbit02;
	public int moneyRandomRabbit03;
	public int moneyRandomRabbit04;
	public int moneyRandomTeller01;
	public int moneyRandomTeller02;
	public int moneyRandomTeller03;
	public int moneyRandomTeller04;
	public int moneyRandomSafebox;
	public int moneyRandomSafebox02;
	public int moneyRandomSafebox03;
	
	GameObject moneyMeercat01;
	GameObject moneyRabbit01;
	GameObject moneyRabbit02;
	GameObject moneyRabbit03;
	GameObject moneyRabbit04;	
	GameObject moneyTeller01;
	GameObject moneyTeller02;
	GameObject moneyTeller03;
	GameObject moneyTeller04;	
	GameObject moneySafebox;
	GameObject moneySafebox02;
	GameObject moneySafebox03;
	
	GameObject highlightMeercat01;
	GameObject highlighRabbit01;
	GameObject highlighRabbit02;
	GameObject highlighRabbit03;
	GameObject highlighRabbit04;	
	GameObject highlighTeller01;
	GameObject highlighTeller02;
	GameObject highlighTeller03;
	GameObject highlighTeller04;	
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

	zebra_Level_09 zebraScript;

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

		zebraScript = GameObject.Find ("zebra").GetComponent<zebra_Level_09>();
		zebraScript.moneyDone.Play();

		totalScore = totalScore + lastLevelScore;
		guiText.text = ("$" + totalScore.ToString());

		moneyRandomMeercat01 = PlayerPrefs.GetInt("moneyRandomMeercat01_level09");
		moneyRandomRabbit01 = PlayerPrefs.GetInt("moneyRandomRabbit01_level09");
		moneyRandomRabbit02 = PlayerPrefs.GetInt("moneyRandomRabbit02_level09");
		moneyRandomRabbit03 = PlayerPrefs.GetInt("moneyRandomRabbit03_level09");
		moneyRandomRabbit04 = PlayerPrefs.GetInt("moneyRandomRabbit04_level09");
		moneyRandomTeller01 = PlayerPrefs.GetInt("moneyRandomTeller01_level09");
		moneyRandomTeller02 = PlayerPrefs.GetInt("moneyRandomTeller02_level09");
		moneyRandomTeller03 = PlayerPrefs.GetInt("moneyRandomTeller03_level09");
		moneyRandomTeller04 = PlayerPrefs.GetInt("moneyRandomTeller04_level09");
		moneyRandomSafebox = PlayerPrefs.GetInt("moneyRandomSafebox_level09");
		moneyRandomSafebox02 =  PlayerPrefs.GetInt("moneyRandomSafebox02_level09");
		moneyRandomSafebox03 =  PlayerPrefs.GetInt("moneyRandomSafebox03_level09");
		Debug.Log (moneyRandomTeller01);


		totalLevelMoney = moneyRandomMeercat01
			+ moneyRandomTeller01 + moneyRandomTeller02 +moneyRandomTeller03 + moneyRandomTeller04 + 
			moneyRandomRabbit01 + moneyRandomRabbit02 + moneyRandomRabbit03 + moneyRandomRabbit04 + 
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
