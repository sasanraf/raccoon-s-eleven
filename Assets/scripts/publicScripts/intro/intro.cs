using UnityEngine;
using System.Collections;

public class intro : MonoBehaviour 
{

	page01 page01;
	page02 page02;
	page03 page03;
	page04 page04;

	GameObject splash;

	int choice = 0;

	// Use this for initialization
	void Start () 
	{

		splash = GameObject.Find ("splash");

		if(PlayerPrefs.GetInt("introAlreadyPlayed") == 1)
		{
			Application.LoadLevel("mainMenu");
		}
		else
		{
			Destroy (splash);
		}

		PlayerPrefs.SetInt("introAlreadyPlayed", 1);

		page01 = GameObject.Find ("intro_1").GetComponent<page01>();
		page02 = GameObject.Find ("intro_2").GetComponent<page02>();
		page03 = GameObject.Find ("intro_3").GetComponent<page03>();
		page04 = GameObject.Find ("intro_4").GetComponent<page04>();
	}

	void OnMouseDown()
	{
		this.audio.Play();

		choice += 1;

		switch(choice)
		{
		case 1: 
			page01.move();
			break;

		case 2: 
			page02.move();
			break;
			
		case 3: 
			page03.move();
			break;
			
		case 4: 
			page04.move();
			break;

		case 5: 
		Application.LoadLevel("mainMenu");
		break;
		}
	}

}
