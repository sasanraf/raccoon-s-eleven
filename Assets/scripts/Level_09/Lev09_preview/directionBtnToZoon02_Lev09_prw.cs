using UnityEngine;
using System.Collections;

public class directionBtnToZoon02_Lev09_prw : MonoBehaviour {

	private cameraZoonChange camera;
	GameObject highlightDirectionLeft;

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
	
	// Use this for initialization
	void Start () 
	{
		camera = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange>();
		highlightDirectionLeft = GameObject.Find ("highlightDirectionLeft");

		moneyMeercat01 = GameObject.Find("moneyTextMeercat01");
		moneyRabbit01 = GameObject.Find("moneyTextRabbit01");
		moneyRabbit02 = GameObject.Find("moneyTextRabbit02");
		moneyRabbit03 = GameObject.Find("moneyTextRabbit03");
		moneyRabbit04 = GameObject.Find("moneyTextRabbit04");		
		moneyTeller01 = GameObject.Find("moneyTextTeller01");
		moneyTeller02 = GameObject.Find("moneyTextTeller02");
		moneyTeller03 = GameObject.Find("moneyTextTeller03");
		moneyTeller04 = GameObject.Find("moneyTextTeller04");		
		moneySafebox = GameObject.Find("moneyTextSafebox");
		moneySafebox02 = GameObject.Find("moneyTextSafebox02");
		moneySafebox03 = GameObject.Find("moneyTextSafebox03");
	}
	
	void OnMouseDown()
	{
		if (highlightDirectionLeft)
		{
			Destroy (highlightDirectionLeft);
		}
		if (moneyMeercat01)
		{
			moneyMeercat01.guiText.enabled = true;
		}
		if (moneyRabbit01)
		{
			moneyRabbit01.guiText.enabled = false;
		}
		if (moneyRabbit02)
		{
			moneyRabbit02.guiText.enabled = false;
		}		
		if (moneyRabbit03)
		{
			moneyRabbit03.guiText.enabled = false;
		}
		if (moneyRabbit04)
		{
			moneyRabbit04.guiText.enabled = true;
		}
		if (moneyTeller01)
		{
			moneyTeller01.guiText.enabled = false;
		}
		if (moneyTeller02)
		{
			moneyTeller02.guiText.enabled = false;
		}
		if (moneyTeller03)
		{
			moneyTeller03.guiText.enabled = true;
		}
		if (moneyTeller04)
		{
			moneyTeller04.guiText.enabled = true;
		}
		if (moneySafebox)
		{
			moneySafebox.guiText.enabled = true;
		}
		if (moneySafebox02)
		{
			moneySafebox02.guiText.enabled = true;
		}
		if (moneySafebox03)
		{
			moneySafebox03.guiText.enabled = false;
		}
		
		camera.movetoZoon2();
	}
}


