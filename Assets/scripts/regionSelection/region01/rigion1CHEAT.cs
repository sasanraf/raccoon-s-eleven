using UnityEngine;
using System.Collections;

public class rigion1CHEAT : MonoBehaviour 
{
	void Update () 
	{
		if (Input.touchCount == 2) 
		{
			if (Time.timeScale==0)
			{
				audio.Play ();
				PlayerPrefs.SetString("bankReg01_Bank01", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank02", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank03", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank04", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank05", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank06", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank07", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank08", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank09", "unlocked");
				PlayerPrefs.SetString("bankReg01_Bank10", "unlocked");

				PlayerPrefs.SetInt("Player Score", 100000);
				Application.LoadLevel("levelsSelect_Reg01");
				
				Time.timeScale = 1;
			}
		}
	}
}


