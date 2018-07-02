using UnityEngine;
using System.Collections;

public class showMoney_Level_10_prw : MonoBehaviour
{
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


	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;
	
	GameObject camera;

	// Use this for initialization
	void Start () 
	{
		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");

		moneyRandomMeercat01 = Random.Range(0, 250);
		moneyRandomMeercat02 = Random.Range(0, 250);
		moneyRandomMeercat03 = Random.Range(0, 250);
		moneyRandomMeercat04 = Random.Range(0, 250);
		moneyRandomMeercat05 = Random.Range(0, 250);
		moneyRandomMeercat06 = Random.Range(0, 250);
		moneyRandomRabbit01 = Random.Range(0, 2000);
		moneyRandomRabbit02 = Random.Range(0, 2000);
		moneyRandomRabbit03 = Random.Range(0, 2000);
		moneyRandomRabbit04 = Random.Range(0, 2000);
		moneyRandomRabbit05 = Random.Range(0, 2000);		
		moneyRandomTeller01 = Random.Range(0, 4000);
		moneyRandomTeller02 = Random.Range(0, 4000);
		moneyRandomTeller03 = Random.Range(0, 4000);
		moneyRandomTeller04 = Random.Range(0, 4000);	
		moneyRandomTeller05 = Random.Range(0, 4000);
		moneyRandomTeller06 = Random.Range(0, 4000);
		moneyRandomTeller07 = Random.Range(0, 4000);
		moneyRandomTeller08 = Random.Range(0, 4000);
		moneyRandomTeller09 = Random.Range(0, 4000);
		moneyRandomTeller10 = Random.Range(0, 4000);
		moneyRandomSafebox = Random.Range(0, 25000);
		moneyRandomSafebox02 = Random.Range(0, 25000);
		moneyRandomSafebox03 = Random.Range(0, 25000);

		PlayerPrefs.SetInt("moneyRandomMeercat01_level10", moneyRandomMeercat01);
		PlayerPrefs.SetInt("moneyRandomMeercat02_level10", moneyRandomMeercat02);
		PlayerPrefs.SetInt("moneyRandomMeercat03_level10", moneyRandomMeercat03);
		PlayerPrefs.SetInt("moneyRandomMeercat04_level10", moneyRandomMeercat04);
		PlayerPrefs.SetInt("moneyRandomMeercat05_level10", moneyRandomMeercat05);
		PlayerPrefs.SetInt("moneyRandomMeercat06_level10", moneyRandomMeercat06);
		PlayerPrefs.SetInt("moneyRandomRabbit01_level10", moneyRandomRabbit01);
		PlayerPrefs.SetInt("moneyRandomRabbit02_level10", moneyRandomRabbit02);
		PlayerPrefs.SetInt("moneyRandomRabbit03_level10", moneyRandomRabbit03);
		PlayerPrefs.SetInt("moneyRandomRabbit04_level10", moneyRandomRabbit04);
		PlayerPrefs.SetInt("moneyRandomRabbit05_level10", moneyRandomRabbit05);
		PlayerPrefs.SetInt("moneyRandomTeller01_level10", moneyRandomTeller01);
		PlayerPrefs.SetInt("moneyRandomTeller02_level10", moneyRandomTeller02);
		PlayerPrefs.SetInt("moneyRandomTeller03_level10", moneyRandomTeller03);
		PlayerPrefs.SetInt("moneyRandomTeller04_level10", moneyRandomTeller04);
		PlayerPrefs.SetInt("moneyRandomTeller05_level10", moneyRandomTeller05);
		PlayerPrefs.SetInt("moneyRandomTeller06_level10", moneyRandomTeller06);
		PlayerPrefs.SetInt("moneyRandomTeller07_level10", moneyRandomTeller07);
		PlayerPrefs.SetInt("moneyRandomTeller08_level10", moneyRandomTeller08);
		PlayerPrefs.SetInt("moneyRandomTeller09_level10", moneyRandomTeller09);
		PlayerPrefs.SetInt("moneyRandomTeller10_level10", moneyRandomTeller10);
		PlayerPrefs.SetInt("moneyRandomSafebox_level10", moneyRandomSafebox);
		PlayerPrefs.SetInt("moneyRandomSafebox02_level10", moneyRandomSafebox02);
		PlayerPrefs.SetInt("moneyRandomSafebox03_level10", moneyRandomSafebox03);
		
		highlightMeercat01 = GameObject.Find ("highlightMonMeercat01");
		highlightMeercat02 = GameObject.Find ("highlightMonMeercat02");
		highlightMeercat03 = GameObject.Find ("highlightMonMeercat03");
		highlightMeercat04 = GameObject.Find ("highlightMonMeercat04");
		highlightMeercat05 = GameObject.Find ("highlightMonMeercat05");
		highlightMeercat06 = GameObject.Find ("highlightMonMeercat06");
		highlighRabbit01 = GameObject.Find ("highlightMonRabbit01");
		highlighRabbit02 = GameObject.Find ("highlightMonRabbit02");
		highlighRabbit03 = GameObject.Find ("highlightMonRabbit03");
		highlighRabbit04 = GameObject.Find ("highlightMonRabbit04");
		highlighRabbit05 = GameObject.Find ("highlightMonRabbit05");		
		highlighTeller01 = GameObject.Find ("highlightMonTeller01");
		highlighTeller02 = GameObject.Find ("highlightMonTeller02");
		highlighTeller03 = GameObject.Find ("highlightMonTeller03");
		highlighTeller04 = GameObject.Find ("highlightMonTeller04");	
		highlighTeller05 = GameObject.Find ("highlightMonTeller05");
		highlighTeller06 = GameObject.Find ("highlightMonTeller06");
		highlighTeller07 = GameObject.Find ("highlightMonTeller07");
		highlighTeller08 = GameObject.Find ("highlightMonTeller08");
		highlighTeller09 = GameObject.Find ("highlightMonTeller09");
		highlighTeller10 = GameObject.Find ("highlightMonTeller10");
		highlighSafebox = GameObject.Find ("highlightRhinoSafebox");
		highlighSafebox02 = GameObject.Find ("highlightRhinoSafebox02");
		highlighSafebox03 = GameObject.Find ("highlightRhinoSafebox03");
		
		moneyMeercat01 = GameObject.Find("moneyTextMeercat01");
		moneyMeercat02 = GameObject.Find("moneyTextMeercat02");
		moneyMeercat03 = GameObject.Find("moneyTextMeercat03");
		moneyMeercat04 = GameObject.Find("moneyTextMeercat04");
		moneyMeercat05 = GameObject.Find("moneyTextMeercat05");
		moneyMeercat06 = GameObject.Find("moneyTextMeercat06");
		moneyRabbit01 = GameObject.Find("moneyTextRabbit01");
		moneyRabbit02 = GameObject.Find("moneyTextRabbit02");
		moneyRabbit03 = GameObject.Find("moneyTextRabbit03");
		moneyRabbit04 = GameObject.Find("moneyTextRabbit04");
		moneyRabbit05 = GameObject.Find("moneyTextRabbit05");		
		moneyTeller01 = GameObject.Find("moneyTextTeller01");
		moneyTeller02 = GameObject.Find("moneyTextTeller02");
		moneyTeller03 = GameObject.Find("moneyTextTeller03");
		moneyTeller04 = GameObject.Find("moneyTextTeller04");
		moneyTeller05 = GameObject.Find("moneyTextTeller05");
		moneyTeller06 = GameObject.Find("moneyTextTeller06");
		moneyTeller07 = GameObject.Find("moneyTextTeller07");
		moneyTeller08 = GameObject.Find("moneyTextTeller08");
		moneyTeller09 = GameObject.Find("moneyTextTeller09");
		moneyTeller10 = GameObject.Find("moneyTextTeller10");
		moneySafebox = GameObject.Find("moneyTextSafebox");
		moneySafebox02 = GameObject.Find("moneyTextSafebox02");
		moneySafebox03 = GameObject.Find("moneyTextSafebox03");
		
		moneyMeercat01.guiText.enabled = true;
		moneyMeercat02.guiText.enabled = true;
		moneyMeercat03.guiText.enabled = false;
		moneyMeercat04.guiText.enabled = false;
		moneyMeercat05.guiText.enabled = false;
		moneyMeercat06.guiText.enabled = false;
		moneyRabbit01.guiText.enabled = false;
		moneyRabbit02.guiText.enabled = false;
		moneyRabbit03.guiText.enabled = false;
		moneyRabbit04.guiText.enabled = false;
		moneyRabbit05.guiText.enabled = false;
		moneyTeller01.guiText.enabled = true;
		moneyTeller02.guiText.enabled = true;
		moneyTeller03.guiText.enabled = false;
		moneyTeller04.guiText.enabled = false;
		moneyTeller05.guiText.enabled = false;
		moneyTeller06.guiText.enabled = false;
		moneyTeller07.guiText.enabled = false;
		moneyTeller08.guiText.enabled = false;
		moneyTeller09.guiText.enabled = false;
		moneyTeller10.guiText.enabled = false;
		moneySafebox.guiText.enabled = true;
		moneySafebox02.guiText.enabled = false;
		moneySafebox03.guiText.enabled = false;
		
		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;

		moneyMeercat01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat04.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat05.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyMeercat06.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit04.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyRabbit05.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller01.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller03.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller04.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller05.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller06.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller07.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller08.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller09.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneyTeller10.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneySafebox.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneySafebox02.guiText.fontSize = (int) (Screen.width * 0.04f);
		moneySafebox03.guiText.fontSize = (int) (Screen.width * 0.04f);
		
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
			
			moneyMeercat02.transform.position = new Vector3(moneyMeercat02_x ,moneyMeercat02_y,0);
			moneyMeercat02.guiText.text = ("$" + moneyRandomMeercat02.ToString());
		}
		
		if (highlightMeercat03 && moneyMeercat03)
		{
			Vector3 highlightMonMeercat3Pos = Camera.main.WorldToScreenPoint (highlightMeercat03.transform.position);
	 		float moneyMeercat03_x = (highlightMonMeercat3Pos.x/screenWidthX);
			float moneyMeercat03_y = (highlightMonMeercat3Pos.y/screenHeightY);
			
			moneyMeercat03.transform.position = new Vector3(moneyMeercat03_x-1 ,moneyMeercat03_y,0);
			moneyMeercat03.guiText.text = ("$" + moneyRandomMeercat03.ToString());
		}
		
		if (highlightMeercat04 && moneyMeercat04)
		{
			Vector3 highlightMonMeercat4Pos = Camera.main.WorldToScreenPoint (highlightMeercat04.transform.position);
	 		float moneyMeercat04_x = (highlightMonMeercat4Pos.x/screenWidthX);
			float moneyMeercat04_y = (highlightMonMeercat4Pos.y/screenHeightY);
			
			moneyMeercat04.transform.position = new Vector3(moneyMeercat04_x-1 ,moneyMeercat04_y,0);
			moneyMeercat04.guiText.text = ("$" + moneyRandomMeercat04.ToString());
		}
		
		if (highlightMeercat05 && moneyMeercat05)
		{
			Vector3 highlightMonMeercat5Pos = Camera.main.WorldToScreenPoint (highlightMeercat05.transform.position);
	 		float moneyMeercat05_x = (highlightMonMeercat5Pos.x/screenWidthX);
			float moneyMeercat05_y = (highlightMonMeercat5Pos.y/screenHeightY);
			
			moneyMeercat05.transform.position = new Vector3(moneyMeercat05_x ,(1-Mathf.Abs(moneyMeercat05_y)),0);
			moneyMeercat05.guiText.text = ("$" + moneyRandomMeercat05.ToString());
			Debug.Log (moneyMeercat05_y);
		}
		
		if (highlightMeercat06 && moneyMeercat06)
		{
			Vector3 highlightMonMeercat6Pos = Camera.main.WorldToScreenPoint (highlightMeercat06.transform.position);
	 		float moneyMeercat06_x = (highlightMonMeercat6Pos.x/screenWidthX);
			float moneyMeercat06_y = (highlightMonMeercat6Pos.y/screenHeightY);
			
			moneyMeercat06.transform.position = new Vector3(moneyMeercat06_x ,(1-Mathf.Abs(moneyMeercat06_y)),0);
			moneyMeercat06.guiText.text = ("$" + moneyRandomMeercat06.ToString());
		}

		if (highlighRabbit01 && moneyRabbit01)
		{
			Vector3 highlightMonRabbit1Pos = Camera.main.WorldToScreenPoint (highlighRabbit01.transform.position);
			float moneyRabbit01_x = (highlightMonRabbit1Pos.x/screenWidthX);
			float moneyRabbit01_y = (highlightMonRabbit1Pos.y/screenHeightY);
			
			moneyRabbit01.transform.position = new Vector3(moneyRabbit01_x ,(1-Mathf.Abs(moneyRabbit01_y)),0);
			moneyRabbit01.guiText.text = ("$" + moneyRandomRabbit01.ToString());			
		}

		if (highlighRabbit02 && moneyRabbit02)
		{
			Vector3 highlightMonRabbit2Pos = Camera.main.WorldToScreenPoint (highlighRabbit02.transform.position);
			float moneyRabbit02_x = (highlightMonRabbit2Pos.x/screenWidthX);
			float moneyRabbit02_y = (highlightMonRabbit2Pos.y/screenHeightY);
			
			moneyRabbit02.transform.position = new Vector3(moneyRabbit02_x ,(1-Mathf.Abs(moneyRabbit02_y)),0);
			moneyRabbit02.guiText.text = ("$" + moneyRandomRabbit02.ToString());	
		}

		if (highlighRabbit03 && moneyRabbit03)
		{
			Vector3 highlightMonRabbit3Pos = Camera.main.WorldToScreenPoint (highlighRabbit03.transform.position);
			float moneyRabbit03_x = (highlightMonRabbit3Pos.x/screenWidthX);
			float moneyRabbit03_y = (highlightMonRabbit3Pos.y/screenHeightY);
			moneyRabbit03.transform.position = new Vector3(moneyRabbit03_x-1 ,(1-Mathf.Abs(moneyRabbit03_y)),0);
			moneyRabbit03.guiText.text = ("$" + moneyRandomRabbit03.ToString());
		
		}
		
		if (highlighRabbit04 && moneyRabbit04)
		{
			Vector3 highlightMonRabbit4Pos = Camera.main.WorldToScreenPoint (highlighRabbit04.transform.position);
			float moneyRabbit04_x = (highlightMonRabbit4Pos.x/screenWidthX);
			float moneyRabbit04_y = (highlightMonRabbit4Pos.y/screenHeightY);
			
			moneyRabbit04.transform.position = new Vector3(moneyRabbit04_x-1 ,(1-Mathf.Abs(moneyRabbit04_y)),0);
			moneyRabbit04.guiText.text = ("$" + moneyRandomRabbit04.ToString());	
		}
		
		if (highlighRabbit05 && moneyRabbit05)
		{
			Vector3 highlightMonRabbit5Pos = Camera.main.WorldToScreenPoint (highlighRabbit05.transform.position);
			float moneyRabbit05_x = (highlightMonRabbit5Pos.x/screenWidthX);
			float moneyRabbit05_y = (highlightMonRabbit5Pos.y/screenHeightY);
			
			moneyRabbit05.transform.position = new Vector3(moneyRabbit05_x-1 ,(1-Mathf.Abs(moneyRabbit05_y)),0);
			moneyRabbit05.guiText.text = ("$" + moneyRandomRabbit05.ToString());	
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
			
			moneyTeller03.transform.position = new Vector3(moneyTeller03_x-1,moneyTeller03_y,0);
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
			
			moneyTeller05.transform.position = new Vector3(moneyTeller05_x,(1-Mathf.Abs(moneyTeller05_y)),0);
			moneyTeller05.guiText.text = ("$" + moneyRandomTeller05.ToString());
		}
		
		if (highlighTeller06 && moneyTeller06)
		{
			Vector3 highlightMonTeller6Pos = Camera.main.WorldToScreenPoint (highlighTeller06.transform.position);
			float moneyTeller06_x = (highlightMonTeller6Pos.x/screenWidthX);
			float moneyTeller06_y = (highlightMonTeller6Pos.y/screenHeightY);
			
			moneyTeller06.transform.position = new Vector3(moneyTeller06_x,(1-Mathf.Abs(moneyTeller06_y)),0);
			moneyTeller06.guiText.text = ("$" + moneyRandomTeller06.ToString());
		}
		
		if (highlighTeller07 && moneyTeller07)
		{
			Vector3 highlightMonTeller7Pos = Camera.main.WorldToScreenPoint (highlighTeller07.transform.position);
			float moneyTeller07_x = (highlightMonTeller7Pos.x/screenWidthX);
			float moneyTeller07_y = (highlightMonTeller7Pos.y/screenHeightY);
			
			moneyTeller07.transform.position = new Vector3(moneyTeller07_x-1,(1-Mathf.Abs(moneyTeller07_y)),0);
			moneyTeller07.guiText.text = ("$" + moneyRandomTeller07.ToString());
		}
		if (highlighTeller07 && moneyTeller07)
		{
			Vector3 highlightMonTeller8Pos = Camera.main.WorldToScreenPoint (highlighTeller08.transform.position);
			float moneyTeller08_x = (highlightMonTeller8Pos.x/screenWidthX);
			float moneyTeller08_y = (highlightMonTeller8Pos.y/screenHeightY);
			
			moneyTeller08.transform.position = new Vector3(moneyTeller08_x-1,(1-Mathf.Abs(moneyTeller08_y)),0);
			moneyTeller08.guiText.text = ("$" + moneyRandomTeller08.ToString());
		}
		
		if (highlighTeller09 && moneyTeller09)
		{
			Vector3 highlightMonTeller9Pos = Camera.main.WorldToScreenPoint (highlighTeller09.transform.position);
			float moneyTeller09_x = (highlightMonTeller9Pos.x/screenWidthX);
			float moneyTeller09_y = (highlightMonTeller9Pos.y/screenHeightY);
			
			moneyTeller09.transform.position = new Vector3(moneyTeller09_x-1,(1-Mathf.Abs(moneyTeller09_y)),0);
			moneyTeller09.guiText.text = ("$" + moneyRandomTeller09.ToString());
		}
		
		if (highlighTeller10 && moneyTeller10)
		{
			Vector3 highlightMonTeller10Pos = Camera.main.WorldToScreenPoint (highlighTeller10.transform.position);
			float moneyTeller10_x = (highlightMonTeller10Pos.x/screenWidthX);
			float moneyTeller10_y = (highlightMonTeller10Pos.y/screenHeightY);
			
			moneyTeller10.transform.position = new Vector3(moneyTeller10_x-1,(1-Mathf.Abs(moneyTeller10_y)),0);
			moneyTeller10.guiText.text = ("$" + moneyRandomTeller10.ToString());
		}

		if (highlighSafebox && moneySafebox)
		{
			Vector3 highlightMonSafeboxPos = Camera.main.WorldToScreenPoint (highlighSafebox.transform.position);
			float moneySafebox_x = (highlightMonSafeboxPos.x/screenWidthX);
			float moneySafebox_y = (highlightMonSafeboxPos.y/screenHeightY);
			
			moneySafebox.transform.position = new Vector3(moneySafebox_x,moneySafebox_y,0);
			moneySafebox.guiText.text = ("$" + moneyRandomSafebox.ToString());
		}
		if (highlighSafebox02 && moneySafebox02)
		{
			Vector3 highlightMonSafebox02Pos = Camera.main.WorldToScreenPoint (highlighSafebox02.transform.position);
			float moneySafebox02_x = (highlightMonSafebox02Pos.x/screenWidthX);
			float moneySafebox02_y = (highlightMonSafebox02Pos.y/screenHeightY);
			
			moneySafebox02.transform.position = new Vector3(moneySafebox02_x-1,moneySafebox02_y,0);
			moneySafebox02.guiText.text = ("$" + moneyRandomSafebox02.ToString());
		}

		if (highlighSafebox03 && moneySafebox03)
		{
			Vector3 highlightMonSafebox03Pos = Camera.main.WorldToScreenPoint (highlighSafebox03.transform.position);
			float moneySafebox03_x = (highlightMonSafebox03Pos.x/screenWidthX);
			float moneySafebox03_y = (highlightMonSafebox03Pos.y/screenHeightY);
			
			moneySafebox03.transform.position = new Vector3(moneySafebox03_x-1,moneySafebox03_y,0);
			moneySafebox03.guiText.text = ("$" + moneyRandomSafebox03.ToString());
		}		
		
	}


}
