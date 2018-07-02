using UnityEngine;
using System.Collections;

public class RESET : MonoBehaviour 
{

	// Use this for initialization
	void OnMouseDown () 
	{
		audio.Play ();
		Time.timeScale=1;
		PlayerPrefs.SetInt("Player Score", 0);
		PlayerPrefs.SetInt("introAlreadyPlayed", 0);
		
		PlayerPrefs.SetInt("zebraArrested", 0);
		PlayerPrefs.SetInt("monkeyArrested", 0);
		PlayerPrefs.SetInt("rhinoArrested", 0);

		//level2
		PlayerPrefs.SetString("bankReg01_Bank02", "");
		PlayerPrefs.SetInt("starsReg01_Bank02", 0);
		PlayerPrefs.SetInt("lastStarsBank02",0);

		//level3
		PlayerPrefs.SetString("bankReg01_Bank03", "");
		PlayerPrefs.SetInt("starsReg01_Bank03", 0);
		PlayerPrefs.SetInt("lastStarsBank03",0);

		//level4
		PlayerPrefs.SetString("bankReg01_Bank04", "");
		PlayerPrefs.SetInt("starsReg01_Bank04", 0);
		PlayerPrefs.SetInt("lastStarsBank04",0);

		//level5
		PlayerPrefs.SetString("bankReg01_Bank05", "");
		PlayerPrefs.SetInt("starsReg01_Bank05", 0);
		PlayerPrefs.SetInt("lastStarsBank05",0);

		//level6
		PlayerPrefs.SetString("bankReg01_Bank06", "");
		PlayerPrefs.SetInt("starsReg01_Bank06", 0);
		PlayerPrefs.SetInt("lastStarsBank06",0);
		
		//level7
		PlayerPrefs.SetString("bankReg01_Bank07", "");
		PlayerPrefs.SetInt("starsReg01_Bank07", 0);
		PlayerPrefs.SetInt("lastStarsBank07",0);

		//level8
		PlayerPrefs.SetString("bankReg01_Bank08", "");
		PlayerPrefs.SetInt("starsReg01_Bank08", 0);
		PlayerPrefs.SetInt("lastStarsBank08",0);
		
		//level9
		PlayerPrefs.SetString("bankReg01_Bank09", "");
		PlayerPrefs.SetInt("starsReg01_Bank09", 0);
		PlayerPrefs.SetInt("lastStarsBank09",0);
		
		//level10
		PlayerPrefs.SetString("bankReg01_Bank10", "");
		PlayerPrefs.SetInt("starsReg01_Bank10", 0);
		PlayerPrefs.SetInt("lastStarsBank10",0);

		PlayerPrefs.SetInt("moneyRandomMeercat01_level07", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit01_level07", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit02_level07", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit03_level07", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit04_level07", 0);
		PlayerPrefs.SetInt("moneyRandomTeller01_level07", 0);
		PlayerPrefs.SetInt("moneyRandomTeller02_level07", 0);
		PlayerPrefs.SetInt("moneyRandomTeller03_level07", 0);
		PlayerPrefs.SetInt("moneyRandomTeller04_level07", 0);
		PlayerPrefs.SetInt("moneyRandomTeller05_level07", 0);
		PlayerPrefs.SetInt("moneyRandomTeller06_level07", 0);
		PlayerPrefs.SetInt("moneyRandomSafebox_level07", 0);
		PlayerPrefs.SetInt("moneyRandomSafebox02_level07", 0);

		PlayerPrefs.SetInt("moneyRandomMeercat01_level08", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit01_level08", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit02_level08", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit03_level08", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit04_level08", 0);
		PlayerPrefs.SetInt("moneyRandomTeller01_level08", 0);
		PlayerPrefs.SetInt("moneyRandomTeller02_level08", 0);
		PlayerPrefs.SetInt("moneyRandomTeller03_level08", 0);
		PlayerPrefs.SetInt("moneyRandomTeller04_level08", 0);
		PlayerPrefs.SetInt("moneyRandomTeller05_level08", 0);
		PlayerPrefs.SetInt("moneyRandomTeller06_level08", 0);
		PlayerPrefs.SetInt("moneyRandomSafebox_level08", 0);
		PlayerPrefs.SetInt("moneyRandomSafebox02_level08", 0);
		
		PlayerPrefs.SetInt("moneyRandomMeercat01_level09", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit01_level09", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit02_level09", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit03_level09", 0);
		PlayerPrefs.SetInt("moneyRandomRabbit04_level09", 0);
		PlayerPrefs.SetInt("moneyRandomTeller01_level09", 0);
		PlayerPrefs.SetInt("moneyRandomTeller02_level09", 0);
		PlayerPrefs.SetInt("moneyRandomTeller03_level09", 0);
		PlayerPrefs.SetInt("moneyRandomTeller04_level09", 0);
		PlayerPrefs.SetInt("moneyRandomSafebox_level09", 0);
		PlayerPrefs.SetInt("moneyRandomSafebox02_level09", 0);
		PlayerPrefs.SetInt("moneyRandomSafebox03_level09", 0);
		
		
		//level8
		PlayerPrefs.SetString("bankReg01_Bank08", "");
		PlayerPrefs.SetInt("starsReg01_Bank08", 0);
		PlayerPrefs.SetInt("lastStarsBank08",0);
		
		//level9
		PlayerPrefs.SetString("bankReg01_Bank09", "");
		PlayerPrefs.SetInt("starsReg01_Bank09", 0);
		PlayerPrefs.SetInt("lastStarsBank09",0);
		
		//level10
		PlayerPrefs.SetString("bankReg01_Bank10", "");
		PlayerPrefs.SetInt("starsReg01_Bank10", 0);
		PlayerPrefs.SetInt("lastStarsBank10",0);
		

		//teamHiring
		PlayerPrefs.SetInt("handTeamHiringAlreadyShown", 0);
		PlayerPrefs.SetInt("rhinoArrested", 0);
		PlayerPrefs.SetInt("monkeyArrested", 0);
		PlayerPrefs.SetInt("zebraArrested", 0);

		//hints
		PlayerPrefs.SetInt("hintLevel02",0);
		PlayerPrefs.SetInt("hintTeamHiringLevel03",0);
		PlayerPrefs.SetInt("hintTeamHiringLevel07",0);
		PlayerPrefs.SetInt("hintPreviewLevel07",0);

		Debug.Log("RESET DONE");
		Application.LoadLevel("levelsSelect_Reg01");

		PlayerPrefs.SetString("chaPos1", "");
		PlayerPrefs.SetString("chaPos2", "");
		PlayerPrefs.SetString("chaPos3", "");
		PlayerPrefs.SetString("chaPos4", "");

		//teamHiring
		PlayerPrefs.SetInt("rhinoArrested", 0);
		PlayerPrefs.SetInt("monkeyArrested", 0);
		PlayerPrefs.SetInt("zebraArrested", 0);
		
		
	}
}
