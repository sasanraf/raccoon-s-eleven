using UnityEngine;
using System.Collections;

public class directionButtonToZoon01_Lev06 : MonoBehaviour {
	
	private cameraZoonChange camera;
	GameObject highlightDirectionRight;

	GameObject moneyMeercat01;
	GameObject moneyMeercat02;
	GameObject moneyMeercat03;
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

	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange>();
		highlightDirectionRight = GameObject.Find ("highlightDirectionRight");

		moneyMeercat01 = GameObject.Find("moneyTextMeercat01");
		moneyMeercat02 = GameObject.Find("moneyTextMeercat02");
		moneyMeercat03 = GameObject.Find("moneyTextMeercat03");
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
	}
	
	void OnMouseDown()
	{
		if (highlightDirectionRight)
		{
			Destroy (highlightDirectionRight);
		}
		if (moneyMeercat01)
		{
			moneyMeercat01.guiText.enabled = true;
		}
		if (moneyMeercat02)
		{
			moneyMeercat02.guiText.enabled = false;
		}
		if (moneyMeercat03)
		{
			moneyMeercat03.guiText.enabled = false;
		}
		if (moneyRabbit01)
		{
			moneyRabbit01.guiText.enabled = true;
		}
		if (moneyRabbit02)
		{
			moneyRabbit02.guiText.enabled = true;
		}
		if (moneyRabbit03)
		{
			moneyRabbit03.guiText.enabled = false;
		}
		if (moneyRabbit04)
		{
			moneyRabbit04.guiText.enabled = false;
		}		
		if (moneyTeller01)
		{
			moneyTeller01.guiText.enabled = true;
		}
		if (moneyTeller02)
		{
			moneyTeller02.guiText.enabled = true;
		}
		if (moneyTeller03)
		{
			moneyTeller03.guiText.enabled = true;
		}
		if (moneyTeller04)
		{
			moneyTeller04.guiText.enabled = false;
		}
		if (moneyTeller05)
		{
			moneyTeller05.guiText.enabled = false;
		}
		if (moneyTeller06)
		{
			moneyTeller06.guiText.enabled = false;
		}	
		if (moneySafebox)
		{
			moneySafebox.guiText.enabled = true;
		}		
		if (moneySafebox02)
		{
			moneySafebox02.guiText.enabled = false;
		}
		camera.movetoZoon1();
	}
}