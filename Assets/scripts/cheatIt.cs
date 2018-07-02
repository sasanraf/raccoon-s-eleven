using UnityEngine;
using System.Collections;

public class cheatIt : MonoBehaviour 
{

	void Start () 
	{
		renderer.enabled = true;
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
		PlayerPrefs.SetInt("rhinoArrested", 0);
		PlayerPrefs.SetInt("monkeyArrested", 0);
		PlayerPrefs.SetInt("zebraArrested", 0);
		
		PlayerPrefs.SetInt("Player Score", 100000);				
				
	}
}
