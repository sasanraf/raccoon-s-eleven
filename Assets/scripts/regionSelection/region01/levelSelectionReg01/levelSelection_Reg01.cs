using UnityEngine;
using System.Collections;

public class levelSelection_Reg01 : MonoBehaviour 
{
	GameObject bankLocked_02;
	GameObject bankLocked_03;
	GameObject bankLocked_04;
	GameObject bankLocked_05;
	GameObject bankLocked_06;
	GameObject bankLocked_07;
	GameObject bankLocked_08;
	GameObject bankLocked_09;
	GameObject bankLocked_10;

	GameObject starFull_02_01;
	GameObject starFull_02_02;
	GameObject starFull_02_03;
	GameObject starEmpty_02_01;
	GameObject starEmpty_02_02;
	GameObject starEmpty_02_03;

	GameObject starFull_03_01;
	GameObject starFull_03_02;
	GameObject starFull_03_03;
	GameObject starEmpty_03_01;
	GameObject starEmpty_03_02;
	GameObject starEmpty_03_03;

	GameObject starFull_04_01;
	GameObject starFull_04_02;
	GameObject starFull_04_03;
	GameObject starEmpty_04_01;
	GameObject starEmpty_04_02;
	GameObject starEmpty_04_03;

	GameObject starFull_05_01;
	GameObject starFull_05_02;
	GameObject starFull_05_03;
	GameObject starEmpty_05_01;
	GameObject starEmpty_05_02;
	GameObject starEmpty_05_03;

	GameObject starFull_06_01;
	GameObject starFull_06_02;
	GameObject starFull_06_03;
	GameObject starEmpty_06_01;
	GameObject starEmpty_06_02;
	GameObject starEmpty_06_03;

	GameObject starFull_07_01;
	GameObject starFull_07_02;
	GameObject starFull_07_03;
	GameObject starEmpty_07_01;
	GameObject starEmpty_07_02;
	GameObject starEmpty_07_03;


	GameObject starFull_08_01;
	GameObject starFull_08_02;
	GameObject starFull_08_03;
	GameObject starEmpty_08_01;
	GameObject starEmpty_08_02;
	GameObject starEmpty_08_03;

	GameObject starFull_09_01;
	GameObject starFull_09_02;
	GameObject starFull_09_03;
	GameObject starEmpty_09_01;
	GameObject starEmpty_09_02;
	GameObject starEmpty_09_03;

	GameObject starFull_10_01;
	GameObject starFull_10_02;
	GameObject starFull_10_03;
	GameObject starEmpty_10_01;
	GameObject starEmpty_10_02;
	GameObject starEmpty_10_03;
	
	void Start () 
	{
		//Stars//////////////////////////////////////////////
		starFull_02_01 = GameObject.Find ("starFull_02_01");
		starFull_02_02 = GameObject.Find ("starFull_02_02");
		starFull_02_03 = GameObject.Find ("starFull_02_03");
		starEmpty_02_01 = GameObject.Find ("starEmpty_02_01");
		starEmpty_02_02 = GameObject.Find ("starEmpty_02_02");
		starEmpty_02_03 = GameObject.Find ("starEmpty_02_03");
		
		starFull_03_01 = GameObject.Find ("starFull_03_01");
		starFull_03_02 = GameObject.Find ("starFull_03_02");
		starFull_03_03 = GameObject.Find ("starFull_03_03");
		starEmpty_03_01 = GameObject.Find ("starEmpty_03_01");
		starEmpty_03_02 = GameObject.Find ("starEmpty_03_02");
		starEmpty_03_03 = GameObject.Find ("starEmpty_03_03");
		
		starFull_04_01 = GameObject.Find ("starFull_04_01");
		starFull_04_02 = GameObject.Find ("starFull_04_02");
		starFull_04_03 = GameObject.Find ("starFull_04_03");
		starEmpty_04_01 = GameObject.Find ("starEmpty_04_01");
		starEmpty_04_02 = GameObject.Find ("starEmpty_04_02");
		starEmpty_04_03 = GameObject.Find ("starEmpty_04_03");
		
		starFull_05_01 = GameObject.Find ("starFull_05_01");
		starFull_05_02 = GameObject.Find ("starFull_05_02");
		starFull_05_03 = GameObject.Find ("starFull_05_03");
		starEmpty_05_01 = GameObject.Find ("starEmpty_05_01");
		starEmpty_05_02 = GameObject.Find ("starEmpty_05_02");
		starEmpty_05_03 = GameObject.Find ("starEmpty_05_03");
		
		starFull_06_01 = GameObject.Find ("starFull_06_01");
		starFull_06_02 = GameObject.Find ("starFull_06_02");
		starFull_06_03 = GameObject.Find ("starFull_06_03");
		starEmpty_06_01 = GameObject.Find ("starEmpty_06_01");
		starEmpty_06_02 = GameObject.Find ("starEmpty_06_02");
		starEmpty_06_03 = GameObject.Find ("starEmpty_06_03");
		
		starFull_07_01 = GameObject.Find ("starFull_07_01");
		starFull_07_02 = GameObject.Find ("starFull_07_02");
		starFull_07_03 = GameObject.Find ("starFull_07_03");
		starEmpty_07_01 = GameObject.Find ("starEmpty_07_01");
		starEmpty_07_02 = GameObject.Find ("starEmpty_07_02");
		starEmpty_07_03 = GameObject.Find ("starEmpty_07_03");
		
		
		starFull_08_01 = GameObject.Find ("starFull_08_01");
		starFull_08_02 = GameObject.Find ("starFull_08_02");
		starFull_08_03 = GameObject.Find ("starFull_08_03");
		starEmpty_08_01 = GameObject.Find ("starEmpty_08_01");
		starEmpty_08_02 = GameObject.Find ("starEmpty_08_02");
		starEmpty_08_03 = GameObject.Find ("starEmpty_08_03");
		
		starFull_09_01 = GameObject.Find ("starFull_09_01");
		starFull_09_02 = GameObject.Find ("starFull_09_02");
		starFull_09_03 = GameObject.Find ("starFull_09_03");
		starEmpty_09_01 = GameObject.Find ("starEmpty_09_01");
		starEmpty_09_02 = GameObject.Find ("starEmpty_09_02");
		starEmpty_09_03 = GameObject.Find ("starEmpty_09_03");
		
		starFull_10_01 = GameObject.Find ("starFull_10_01");
		starFull_10_02 = GameObject.Find ("starFull_10_02");
		starFull_10_03 = GameObject.Find ("starFull_10_03");
		starEmpty_10_01 = GameObject.Find ("starEmpty_10_01");
		starEmpty_10_02 = GameObject.Find ("starEmpty_10_02");
		starEmpty_10_03 = GameObject.Find ("starEmpty_10_03");

		//bank 2//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_02 = GameObject.Find ("bankLocked_02");
		if ((PlayerPrefs.GetString("bankReg01_Bank02") == "unlocked") && bankLocked_02)
		{
			Destroy(bankLocked_02);
			if (PlayerPrefs.GetInt("starsReg01_Bank02") >=1)
			{
				starEmpty_02_01.renderer.enabled = true;
				starEmpty_02_02.renderer.enabled = true;
				starEmpty_02_03.renderer.enabled = true;
			}
		}

		//check always show the highest stars
		int checkNewStarsBank02 = PlayerPrefs.GetInt("starsReg01_Bank02");
		int checkLastStarsBank02 = PlayerPrefs.GetInt("lastStarsBank02");
		if (checkLastStarsBank02 >= checkNewStarsBank02)
		{
			checkNewStarsBank02 = checkLastStarsBank02;
			PlayerPrefs.SetInt("starsReg01_Bank02", checkLastStarsBank02);
		}
		else
		{
			checkLastStarsBank02 = checkNewStarsBank02;
		}

		if (PlayerPrefs.GetInt("starsReg01_Bank02") == 1)
		{
			starFull_02_01.renderer.enabled = true;
		}

		if (PlayerPrefs.GetInt("starsReg01_Bank02") == 2)
		{
			starFull_02_01.renderer.enabled = true;
			starFull_02_02.renderer.enabled = true;
		}

		if (PlayerPrefs.GetInt("starsReg01_Bank02") == 3)
		{
			starFull_02_01.renderer.enabled = true;
			starFull_02_02.renderer.enabled = true;
			starFull_02_03.renderer.enabled = true;
		}

		PlayerPrefs.SetInt("lastStarsBank02", checkNewStarsBank02);


		//bank 3//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_03 = GameObject.Find ("bankLocked_03");
		if ((PlayerPrefs.GetString("bankReg01_Bank03") == "unlocked") && bankLocked_03)
		{
			Destroy(bankLocked_03);
			if (PlayerPrefs.GetInt("starsReg01_Bank03") >=1)
			{
				starEmpty_03_01.renderer.enabled = true;
				starEmpty_03_02.renderer.enabled = true;
				starEmpty_03_03.renderer.enabled = true;
			}
		}

		//check always show the highest stars
		int checkNewStarsBank03 = PlayerPrefs.GetInt("starsReg01_Bank03");
		int checkLastStarsBank03 = PlayerPrefs.GetInt("lastStarsBank03");
		if (checkLastStarsBank03 >= checkNewStarsBank03)
		{
			checkNewStarsBank03 = checkLastStarsBank03;
			PlayerPrefs.SetInt("starsReg01_Bank03", checkLastStarsBank03);
		}
		else
		{
			checkLastStarsBank03 = checkNewStarsBank03;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank03") == 1)
		{
			starFull_03_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank03") == 2)
		{
			starFull_03_01.renderer.enabled = true;
			starFull_03_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank03") == 3)
		{
			starFull_03_01.renderer.enabled = true;
			starFull_03_02.renderer.enabled = true;
			starFull_03_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank03", checkNewStarsBank03);

		bankLocked_03 = GameObject.Find ("bankLocked_03");
		if ((PlayerPrefs.GetString("bankReg01_Bank03") == "unlocked") && bankLocked_03)
		{
			Destroy(bankLocked_03);
			if (PlayerPrefs.GetInt("starsReg01_Bank03") >=1)
			{
				starEmpty_03_01.renderer.enabled = true;
				starEmpty_03_02.renderer.enabled = true;
				starEmpty_03_03.renderer.enabled = true;
			}
		}

		//bank 4//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_04 = GameObject.Find ("bankLocked_04");
		if ((PlayerPrefs.GetString("bankReg01_Bank04") == "unlocked") && bankLocked_04)
		{
			Destroy(bankLocked_04);
			if (PlayerPrefs.GetInt("starsReg01_Bank04") >=1)
			{
				starEmpty_04_01.renderer.enabled = true;
				starEmpty_04_02.renderer.enabled = true;
				starEmpty_04_03.renderer.enabled = true;
			}
		}

		//check always show the highest stars
		int checkNewStarsBank04 = PlayerPrefs.GetInt("starsReg01_Bank04");
		int checkLastStarsBank04 = PlayerPrefs.GetInt("lastStarsBank04");
		if (checkLastStarsBank04 >= checkNewStarsBank04)
		{
			checkNewStarsBank04 = checkLastStarsBank04;
			PlayerPrefs.SetInt("starsReg01_Bank04", checkLastStarsBank04);
		}
		else
		{
			checkLastStarsBank04 = checkNewStarsBank04;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank04") == 1)
		{
			starFull_04_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank04") == 2)
		{
			starFull_04_01.renderer.enabled = true;
			starFull_04_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank04") == 3)
		{
			starFull_04_01.renderer.enabled = true;
			starFull_04_02.renderer.enabled = true;
			starFull_04_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank04", checkNewStarsBank04);

		//bank 5//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_05 = GameObject.Find ("bankLocked_05");
		if ((PlayerPrefs.GetString("bankReg01_Bank05") == "unlocked") && bankLocked_05)
		{
			Destroy(bankLocked_05);
			if (PlayerPrefs.GetInt("starsReg01_Bank05") >=1)
			{
				starEmpty_05_01.renderer.enabled = true;
				starEmpty_05_02.renderer.enabled = true;
				starEmpty_05_03.renderer.enabled = true;
			}
		}

		//check always show the highest stars
		int checkNewStarsBank05 = PlayerPrefs.GetInt("starsReg01_Bank05");
		int checkLastStarsBank05 = PlayerPrefs.GetInt("lastStarsBank05");
		if (checkLastStarsBank05 >= checkNewStarsBank05)
		{
			checkNewStarsBank05 = checkLastStarsBank05;
			PlayerPrefs.SetInt("starsReg01_Bank05", checkLastStarsBank05);
		}
		else
		{
			checkLastStarsBank05 = checkNewStarsBank05;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank05") == 1)
		{
			starFull_05_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank05") == 2)
		{
			starFull_05_01.renderer.enabled = true;
			starFull_05_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank05") == 3)
		{
			starFull_05_01.renderer.enabled = true;
			starFull_05_02.renderer.enabled = true;
			starFull_05_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank05", checkNewStarsBank05);

		//bank 6//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_06 = GameObject.Find ("bankLocked_06");
		if ((PlayerPrefs.GetString("bankReg01_Bank06") == "unlocked") && bankLocked_06)
		{
			Destroy(bankLocked_06);
			if (PlayerPrefs.GetInt("starsReg01_Bank06") >=1)
			{
				starEmpty_06_01.renderer.enabled = true;
				starEmpty_06_02.renderer.enabled = true;
				starEmpty_06_03.renderer.enabled = true;
			}
		}

		//check always show the highest stars
		int checkNewStarsBank06 = PlayerPrefs.GetInt("starsReg01_Bank06");
		int checkLastStarsBank06 = PlayerPrefs.GetInt("lastStarsBank06");
		if (checkLastStarsBank06 >= checkNewStarsBank06)
		{
			checkNewStarsBank06 = checkLastStarsBank06;
			PlayerPrefs.SetInt("starsReg01_Bank06", checkLastStarsBank06);
		}
		else
		{
			checkLastStarsBank06 = checkNewStarsBank06;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank06") == 1)
		{
			starFull_06_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank06") == 2)
		{
			starFull_06_01.renderer.enabled = true;
			starFull_06_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank06") == 3)
		{
			starFull_06_01.renderer.enabled = true;
			starFull_06_02.renderer.enabled = true;
			starFull_06_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank06", checkNewStarsBank06);

		//bank 7//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_07 = GameObject.Find ("bankLocked_07");
		if ((PlayerPrefs.GetString("bankReg01_Bank07") == "unlocked") && bankLocked_07)
		{
			Destroy(bankLocked_07);
			if (PlayerPrefs.GetInt("starsReg01_Bank07") >=1)
			{
				starEmpty_07_01.renderer.enabled = true;
				starEmpty_07_02.renderer.enabled = true;
				starEmpty_07_03.renderer.enabled = true;
			}
		}
		
		//check always show the highest stars
		int checkNewStarsBank07 = PlayerPrefs.GetInt("starsReg01_Bank07");
		int checkLastStarsBank07 = PlayerPrefs.GetInt("lastStarsBank07");
		if (checkLastStarsBank07 >= checkNewStarsBank07)
		{
			checkNewStarsBank07 = checkLastStarsBank07;
			PlayerPrefs.SetInt("starsReg01_Bank07", checkLastStarsBank07);
		}
		else
		{
			checkLastStarsBank07 = checkNewStarsBank07;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank07") == 1)
		{
			starFull_07_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank07") == 2)
		{
			starFull_07_01.renderer.enabled = true;
			starFull_07_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank07") == 3)
		{
			starFull_07_01.renderer.enabled = true;
			starFull_07_02.renderer.enabled = true;
			starFull_07_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank07", checkNewStarsBank07);


		//bank 8//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_08 = GameObject.Find ("bankLocked_08");
		if ((PlayerPrefs.GetString("bankReg01_Bank08") == "unlocked") && bankLocked_08)
		{
			Destroy(bankLocked_08);
			if (PlayerPrefs.GetInt("starsReg01_Bank08") >=1)
			{
				starEmpty_08_01.renderer.enabled = true;
				starEmpty_08_02.renderer.enabled = true;
				starEmpty_08_03.renderer.enabled = true;
			}
		}
		
		//check always show the highest stars
		int checkNewStarsBank08 = PlayerPrefs.GetInt("starsReg01_Bank08");
		int checkLastStarsBank08 = PlayerPrefs.GetInt("lastStarsBank08");
		if (checkLastStarsBank08 >= checkNewStarsBank08)
		{
			checkNewStarsBank08 = checkLastStarsBank08;
			PlayerPrefs.SetInt("starsReg01_Bank08", checkLastStarsBank08);
		}
		else
		{
			checkLastStarsBank08 = checkNewStarsBank08;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank08") == 1)
		{
			starFull_08_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank08") == 2)
		{
			starFull_08_01.renderer.enabled = true;
			starFull_08_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank08") == 3)
		{
			starFull_08_01.renderer.enabled = true;
			starFull_08_02.renderer.enabled = true;
			starFull_08_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank08", checkNewStarsBank08);

		//bank 9//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_09 = GameObject.Find ("bankLocked_09");
		if ((PlayerPrefs.GetString("bankReg01_Bank09") == "unlocked") && bankLocked_09)
		{
			Destroy(bankLocked_09);
			if (PlayerPrefs.GetInt("starsReg01_Bank09") >=1)
			{
				starEmpty_09_01.renderer.enabled = true;
				starEmpty_09_02.renderer.enabled = true;
				starEmpty_09_03.renderer.enabled = true;
			}
		}
		
		//check always show the highest stars
		int checkNewStarsBank09 = PlayerPrefs.GetInt("starsReg01_Bank09");
		int checkLastStarsBank09 = PlayerPrefs.GetInt("lastStarsBank09");
		if (checkLastStarsBank09 >= checkNewStarsBank09)
		{
			checkNewStarsBank09 = checkLastStarsBank09;
			PlayerPrefs.SetInt("starsReg01_Bank09", checkLastStarsBank09);
		}
		else
		{
			checkLastStarsBank09 = checkNewStarsBank09;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank09") == 1)
		{
			starFull_09_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank09") == 2)
		{
			starFull_09_01.renderer.enabled = true;
			starFull_09_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank09") == 3)
		{
			starFull_09_01.renderer.enabled = true;
			starFull_09_02.renderer.enabled = true;
			starFull_09_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank09", checkNewStarsBank09);

		//bank 10//////////////////////////////////////////////////////////////////////////////////////////////
		bankLocked_10 = GameObject.Find ("bankLocked_10");
		if ((PlayerPrefs.GetString("bankReg01_Bank10") == "unlocked") && bankLocked_10)
		{
			Destroy(bankLocked_10);
			if (PlayerPrefs.GetInt("starsReg01_Bank10") >=1)
			{
				starEmpty_10_01.renderer.enabled = true;
				starEmpty_10_02.renderer.enabled = true;
				starEmpty_10_03.renderer.enabled = true;
			}
		}
		
		//check always show the highest stars
		int checkNewStarsBank10 = PlayerPrefs.GetInt("starsReg01_Bank10");
		int checkLastStarsBank10 = PlayerPrefs.GetInt("lastStarsBank10");
		if (checkLastStarsBank10 >= checkNewStarsBank10)
		{
			checkNewStarsBank10 = checkLastStarsBank10;
			PlayerPrefs.SetInt("starsReg01_Bank10", checkLastStarsBank10);
		}
		else
		{
			checkLastStarsBank10 = checkNewStarsBank10;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank10") == 1)
		{
			starFull_10_01.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank10") == 2)
		{
			starFull_10_01.renderer.enabled = true;
			starFull_10_02.renderer.enabled = true;
		}
		
		if (PlayerPrefs.GetInt("starsReg01_Bank10") == 3)
		{
			starFull_10_01.renderer.enabled = true;
			starFull_10_02.renderer.enabled = true;
			starFull_10_03.renderer.enabled = true;
		}
		PlayerPrefs.SetInt("lastStarsBank10", checkNewStarsBank10);
		
	}


}

