using UnityEngine;
using System.Collections;

public class directionBtnZoon24_prw : MonoBehaviour {

	cameraZoonChange_level10 camera;
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

	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange_level10>();

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
	}
	void OnMouseDown()
	{
		moneyMeercat01.guiText.enabled = false;
		moneyMeercat02.guiText.enabled = false;
		moneyMeercat03.guiText.enabled = false;
		moneyMeercat04.guiText.enabled = false;
		moneyMeercat05.guiText.enabled = false;
		moneyMeercat06.guiText.enabled = false;
		moneyRabbit01.guiText.enabled = false;
		moneyRabbit02.guiText.enabled = false;
		moneyRabbit03.guiText.enabled = true;
		moneyRabbit04.guiText.enabled = true;
		moneyRabbit05.guiText.enabled = true;
		moneyTeller01.guiText.enabled = false;
		moneyTeller02.guiText.enabled = false;
		moneyTeller03.guiText.enabled = false;
		moneyTeller04.guiText.enabled = false;
		moneyTeller05.guiText.enabled = false;
		moneyTeller06.guiText.enabled = false;
		moneyTeller07.guiText.enabled = true;
		moneyTeller08.guiText.enabled = true;
		moneyTeller09.guiText.enabled = true;
		moneyTeller10.guiText.enabled = true;
		moneySafebox.guiText.enabled = false;
		moneySafebox02.guiText.enabled = false;
		moneySafebox03.guiText.enabled = false;
		camera.movetoZoon24();
	}
}

