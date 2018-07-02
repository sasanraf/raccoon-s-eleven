using UnityEngine;
using System.Collections;

public class directionButtonToZoon01_Lev04 : MonoBehaviour {
	
	private cameraZoonChange camera;
	GameObject highlightDirectionRight;

	GameObject moneyMeercat01;
	GameObject moneyMeercat02;
	GameObject moneyMeercat03;
	GameObject moneyMeercat04;
	GameObject moneyRabbit01;
	GameObject moneyRabbit02;
	GameObject moneyTeller01;
	GameObject moneyTeller02;
	GameObject moneyTeller03;
	GameObject moneyTeller04;
	GameObject moneyTeller05;
	GameObject moneySafebox;

	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange>();
		highlightDirectionRight = GameObject.Find ("highlightDirectionRight");

		moneyMeercat01 = GameObject.Find("moneyTextMeercat01");
		moneyMeercat02 = GameObject.Find("moneyTextMeercat02");
		moneyMeercat03 = GameObject.Find("moneyTextMeercat03");
		moneyMeercat04 = GameObject.Find("moneyTextMeercat04");
		moneyRabbit01 = GameObject.Find("moneyTextRabbit01");
		moneyRabbit02 = GameObject.Find("moneyTextRabbit02");
		moneyTeller01 = GameObject.Find("moneyTextTeller01");
		moneyTeller02 = GameObject.Find("moneyTextTeller02");
		moneyTeller03 = GameObject.Find("moneyTextTeller03");
		moneyTeller04 = GameObject.Find("moneyTextTeller04");
		moneyTeller05 = GameObject.Find("moneyTextTeller05");
		moneySafebox = GameObject.Find("moneyTextSafebox");
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
			moneyMeercat02.guiText.enabled = true;
		}
		if (moneyMeercat03)
		{
			moneyMeercat03.guiText.enabled = true;
		}
		if (moneyMeercat04)
		{
			moneyMeercat04.guiText.enabled = false;
		}
		if (moneyRabbit01)
		{
			moneyRabbit01.guiText.enabled = false;
		}
		if (moneyRabbit02)
		{
			moneyRabbit02.guiText.enabled = false;
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
		if (moneySafebox)
		{
			moneySafebox.guiText.enabled = false;
		}
		camera.movetoZoon1();
	}
}