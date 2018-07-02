using UnityEngine;
using System.Collections;

public class showMoney_Level_08_prw : MonoBehaviour
{
	public int moneyRandomMeercat01;
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
	public int moneyRandomSafebox02;

	GameObject moneyMeercat01;
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
	GameObject moneySafebox02;

	GameObject highlightMeercat01;
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
	GameObject highlighSafebox02;


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
		moneyRandomRabbit01 = Random.Range(0, 2000);
		moneyRandomRabbit02 = Random.Range(0, 2000);
		moneyRandomRabbit03 = Random.Range(0, 2000);
		moneyRandomRabbit04 = Random.Range(0, 2000);		
		moneyRandomTeller01 = Random.Range(0, 3500);
		moneyRandomTeller02 = Random.Range(0, 3500);
		moneyRandomTeller03 = Random.Range(0, 3500);
		moneyRandomTeller04 = Random.Range(0, 3500);
		moneyRandomTeller05 = Random.Range(0, 3500);
		moneyRandomTeller06 = Random.Range(0, 3500);	
		moneyRandomSafebox = Random.Range(0, 15000);
		moneyRandomSafebox02 = Random.Range(0, 25000);

		PlayerPrefs.SetInt("moneyRandomMeercat01_level08", moneyRandomMeercat01);
		PlayerPrefs.SetInt("moneyRandomRabbit01_level08", moneyRandomRabbit01);
		PlayerPrefs.SetInt("moneyRandomRabbit02_level08", moneyRandomRabbit02);
		PlayerPrefs.SetInt("moneyRandomRabbit03_level08", moneyRandomRabbit03);
		PlayerPrefs.SetInt("moneyRandomRabbit04_level08", moneyRandomRabbit04);
		PlayerPrefs.SetInt("moneyRandomTeller01_level08", moneyRandomTeller01);
		PlayerPrefs.SetInt("moneyRandomTeller02_level08", moneyRandomTeller02);
		PlayerPrefs.SetInt("moneyRandomTeller03_level08", moneyRandomTeller03);
		PlayerPrefs.SetInt("moneyRandomTeller04_level08", moneyRandomTeller04);
		PlayerPrefs.SetInt("moneyRandomTeller05_level08", moneyRandomTeller05);
		PlayerPrefs.SetInt("moneyRandomTeller06_level08", moneyRandomTeller06);
		PlayerPrefs.SetInt("moneyRandomSafebox_level08", moneyRandomSafebox);
		PlayerPrefs.SetInt("moneyRandomSafebox02_level08", moneyRandomSafebox02);

		highlightMeercat01 = GameObject.Find ("highlightMonMeercat01");
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
		highlighSafebox02 = GameObject.Find ("highlightRhinoSafebox02");

		
		moneyMeercat01 = GameObject.Find("moneyTextMeercat01");
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
		moneySafebox02 = GameObject.Find("moneyTextSafebox02");
		
		moneyMeercat01.guiText.enabled = false;
		moneyRabbit01.guiText.enabled = true;
		moneyRabbit02.guiText.enabled = true;
		moneyRabbit03.guiText.enabled = true;
		moneyRabbit04.guiText.enabled = false;
		moneyTeller01.guiText.enabled = true;
		moneyTeller02.guiText.enabled = true;
		moneyTeller03.guiText.enabled = true;
		moneyTeller04.guiText.enabled = true;
		moneyTeller05.guiText.enabled = true;
		moneyTeller06.guiText.enabled = true;
		moneySafebox.guiText.enabled = false;
		moneySafebox02.guiText.enabled = false;

		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;

		moneyMeercat01.guiText.fontSize = (int) (Screen.width * 0.04f);
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
		moneySafebox02.guiText.fontSize = (int) (Screen.width * 0.04f);	


		if (highlightMeercat01 && moneyMeercat01)
		{
			Vector3 highlightMonMeercat1Pos = Camera.main.WorldToScreenPoint (highlightMeercat01.transform.position);
	 		float moneyMeercat01_x = (highlightMonMeercat1Pos.x/screenWidthX);
			float moneyMeercat01_y = (highlightMonMeercat1Pos.y/screenHeightY);
			
			moneyMeercat01.transform.position = new Vector3(moneyMeercat01_x-1 ,moneyMeercat01_y,0);
			moneyMeercat01.guiText.text = ("$" + moneyRandomMeercat01.ToString());
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
			
			moneyRabbit02.transform.position = new Vector3(moneyRabbit02_x ,moneyRabbit02_y,0);
			moneyRabbit02.guiText.text = ("$" + moneyRandomRabbit02.ToString());
			
		}

		if (highlighRabbit03 && moneyRabbit03)
		{
			Vector3 highlightMonRabbit3Pos = Camera.main.WorldToScreenPoint (highlighRabbit03.transform.position);
			float moneyRabbit03_x = (highlightMonRabbit3Pos.x/screenWidthX);
			float moneyRabbit03_y = (highlightMonRabbit3Pos.y/screenHeightY);
			
			moneyRabbit03.transform.position = new Vector3(moneyRabbit03_x ,moneyRabbit03_y,0);
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
			
			moneyTeller04.transform.position = new Vector3(moneyTeller04_x,moneyTeller04_y,0);
			moneyTeller04.guiText.text = ("$" + moneyRandomTeller04.ToString());
		}

		if (highlighTeller05 && moneyTeller05)
		{
			Vector3 highlightMonTeller5Pos = Camera.main.WorldToScreenPoint (highlighTeller05.transform.position);
			float moneyTeller05_x = (highlightMonTeller5Pos.x/screenWidthX);
			float moneyTeller05_y = (highlightMonTeller5Pos.y/screenHeightY);
			
			moneyTeller05.transform.position = new Vector3(moneyTeller05_x,moneyTeller05_y,0);
			moneyTeller05.guiText.text = ("$" + moneyRandomTeller05.ToString());
		}
		
		if (highlighTeller06 && moneyTeller06)
		{
			Vector3 highlightMonTeller6Pos = Camera.main.WorldToScreenPoint (highlighTeller06.transform.position);
			float moneyTeller06_x = (highlightMonTeller6Pos.x/screenWidthX);
			float moneyTeller06_y = (highlightMonTeller6Pos.y/screenHeightY);
			
			moneyTeller06.transform.position = new Vector3(moneyTeller06_x,moneyTeller06_y,0);
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
		if (highlighSafebox02 && moneySafebox02)
		{
			Vector3 highlightMonSafebox02Pos = Camera.main.WorldToScreenPoint (highlighSafebox02.transform.position);
			float moneySafebox02_x = (highlightMonSafebox02Pos.x/screenWidthX);
			float moneySafebox02_y = (highlightMonSafebox02Pos.y/screenHeightY);
			
			moneySafebox02.transform.position = new Vector3(moneySafebox02_x-1,moneySafebox02_y,0);
			moneySafebox02.guiText.text = ("$" + moneyRandomSafebox02.ToString());
		}		
		
	}


}
