using UnityEngine;
using System.Collections;

public class bottunDone_TeamSelLev03 : MonoBehaviour {

	GameObject rhino;
	GameObject monkey;
	GameObject zebra;

	moneyToBuy money;

	public string chaPos1 = "";
	public string chaPos2 = "";
	public string chaPos3 = "";
	public string chaPos4 = "";

	//rhino_chaPick rhinoCheck;

	void Start () 
	{
		PlayerPrefs.SetString("chaPos1", "");
		PlayerPrefs.SetString("chaPos2", "");
		PlayerPrefs.SetString("chaPos3", "");
		PlayerPrefs.SetString("chaPos4", "");

		rhino = GameObject.Find ("rhino");
		monkey =  GameObject.Find ("monkey");
		zebra =  GameObject.Find ("zebra");

		int totalScore = PlayerPrefs.GetInt("Player Score");

		//rhinoCheck = GameObject.Find ("rhino").GetComponent<rhino_l03_chaPick>();

		money = GameObject.Find ("scoreGUItext").GetComponent<moneyToBuy>();
		
		if (totalScore < 10000)
		{
			Destroy (rhino);
		}
	}


	void OnMouseDown  () 
	{
		Time.timeScale=1;
		this.audio.Play();

		PlayerPrefs.SetInt("Player Score", money.moneyLeft);
		PlayerPrefs.SetString("chaPos1", chaPos1);
		PlayerPrefs.SetString("chaPos2", chaPos2);
		PlayerPrefs.SetString("chaPos3", chaPos3);
		PlayerPrefs.SetString("chaPos4", chaPos4);

		if (((PlayerPrefs.GetString("chaPos1") =="zebra") || (PlayerPrefs.GetString("chaPos2") == "zebra") || (PlayerPrefs.GetString("chaPos3") == "zebra") || (PlayerPrefs.GetString("chaPos4") == "zebra")) 
		    && PlayerPrefs.GetString("chaPos2") != "" )
		{
			Application.LoadLevel("L3_final");
		}

	}

}

