using UnityEngine;
using System.Collections;

public class monkey_chaPickLev08 : MonoBehaviour {

	//mouse and screen 
	private Vector3 screenPoint;
	private float mouseX;
	private float mouseY;
	private Vector3 mouseposition;
	
	GameObject pauseBar;
	GameObject monkeyBW;
	
	GameObject dummyPos1;
	GameObject dummyPos2;
	GameObject dummyPos3;
	GameObject dummyPos4;
	
	dummyChaMenuPos1 pos1Check;
	dummyChaMenuPos2 pos2Check;
	dummyChaMenuPos3 pos3Check;
	dummyChaMenuPos4 pos4Check;
	
	pauseBarScale pauseBarScript;
	pauseEndScale pauseEndScript;
	
	public bool monkeyIsOnShelf = false;
	
	bottunDone_TeamSelLev08 setPosButtonScript;
	
	moneyToBuy money;
	
	GameObject handCuffs_monkey;

	bool monkeyWasArrestedBefore = false;

	GameObject monkeyInfo;
	
	void Start ()
	{
		monkeyInfo = GameObject.Find ("monkeyInfo");
		handCuffs_monkey = GameObject.Find("handCuffs_monkey");
		
		if (PlayerPrefs.GetInt("monkeyArrested") == 1)
		{
			handCuffs_monkey.renderer.enabled = true;
		}

		int totalScore = PlayerPrefs.GetInt("Player Score");
		if (PlayerPrefs.GetInt("monkeyArrested") == 1 && totalScore < 20000)
		{
			Destroy (gameObject);
		}
		
		money = GameObject.Find ("scoreGUItext").GetComponent<moneyToBuy>();
		
		pauseBar = GameObject.Find ("pauseBar");
		monkeyBW = GameObject.Find ("monkeyBW");
		
		pauseBarScript = GameObject.Find ("pauseBar").GetComponent<pauseBarScale>();
		pauseEndScript = GameObject.Find ("pauseEnd").GetComponent<pauseEndScale>();
		
		setPosButtonScript = GameObject.Find ("bottunDone").GetComponent<bottunDone_TeamSelLev08>();
		
		dummyPos1 = GameObject.Find ("dummyPos1");
		dummyPos2 = GameObject.Find ("dummyPos2");
		dummyPos3 = GameObject.Find ("dummyPos3");
		dummyPos4 = GameObject.Find ("dummyPos4");
		

		
		pos1Check = GameObject.Find ("dummyPos1").GetComponent<dummyChaMenuPos1>();
		pos2Check = GameObject.Find ("dummyPos2").GetComponent<dummyChaMenuPos2>();
		pos3Check = GameObject.Find ("dummyPos3").GetComponent<dummyChaMenuPos3>();
		pos4Check = GameObject.Find ("dummyPos4").GetComponent<dummyChaMenuPos4>();

	}	



	
	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

	}
	
	void OnMouseDrag()  		
	{		
		monkeyInfo.renderer.enabled = true;
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;
		
	}

	void OnMouseExit()
	{
		monkeyInfo.renderer.enabled = false;
	}
	
	void OnMouseUp () 
	{
		if (transform.position.x < pauseBar.transform.position.x+2)
		{
			if (PlayerPrefs.GetInt("monkeyArrested") == 0 || 
			    (PlayerPrefs.GetInt("monkeyArrested") == 1  && ((money.moneyLeft - 20000) >= 0))) 
			{
				if (pos1Check.pos1IsFree == true && monkeyIsOnShelf == false)
				{
					Debug.Log ("monkey pos1Check.pos1IsFree == true && monkeyIsOnShelf == false");
					pauseBarScript.scaleOneCha();
					pauseEndScript.scaleOneCha();
					this.audio.Play();
					transform.position = dummyPos1.transform.position;
					
					pos1Check.pos1IsFree = false;
					monkeyIsOnShelf = true;
					setPosButtonScript.chaPos1 = "monkey";
					
					if (PlayerPrefs.GetInt("monkeyArrested") == 1)
					{
						money.audio.Play ();
						money.buy(20000);
						handCuffs_monkey.renderer.enabled = false;
						PlayerPrefs.SetInt("monkeyArrested" ,0) ;
						monkeyWasArrestedBefore = true;
					}
				}
				
				else if (pos2Check.pos2IsFree == true && monkeyIsOnShelf == false)
				{
					Debug.Log ("monkey pos2Check.pos2IsFree == true && monkeyIsOnShelf == false");
					pauseBarScript.scaleTwoCha();
					pauseEndScript.scaleTwoCha();
					this.audio.Play();
					transform.position = dummyPos2.transform.position;
					
					pos2Check.pos2IsFree = false;
					monkeyIsOnShelf = true;
					setPosButtonScript.chaPos2 = "monkey";
					
					if (PlayerPrefs.GetInt("monkeyArrested") == 1)
					{
						money.audio.Play ();
						money.buy(20000);
						handCuffs_monkey.renderer.enabled = false;
						PlayerPrefs.SetInt("monkeyArrested", 0);
						monkeyWasArrestedBefore = true;
					}
				}
				
				else if (pos3Check.pos3IsFree == true && monkeyIsOnShelf == false)
				{
					Debug.Log ("monkey pos3Check.pos3IsFree == true && monkeyIsOnShelf == false");
					pauseBarScript.scaleThreeCha();
					pauseEndScript.scaleThreeCha();
					this.audio.Play();
					transform.position = dummyPos3.transform.position;
					
					pos3Check.pos3IsFree = false;
					monkeyIsOnShelf = true;
					setPosButtonScript.chaPos3 = "monkey";
					
					if (PlayerPrefs.GetInt("monkeyArrested") == 1)
					{
						money.audio.Play ();
						money.buy(20000);
						handCuffs_monkey.renderer.enabled = false;
						PlayerPrefs.SetInt("monkeyArrested", 0);
						monkeyWasArrestedBefore = true;
					}
				}
				
				else if (pos4Check.pos4IsFree == true && monkeyIsOnShelf == false)
				{
					Debug.Log ("monkey pos4Check.pos4IsFree == true && monkeyIsOnShelf == false");
					pauseBarScript.scaleFourCha();
					pauseEndScript.scaleFourCha();
					this.audio.Play();
					transform.position = dummyPos4.transform.position;
					
					pos4Check.pos4IsFree = false;
					monkeyIsOnShelf = true;
					setPosButtonScript.chaPos4 = "monkey";

					if (PlayerPrefs.GetInt("monkeyArrested") == 1)
					{
						money.audio.Play ();
						money.buy(20000);
						handCuffs_monkey.renderer.enabled = false;
						PlayerPrefs.SetInt("monkeyArrested", 0);
						monkeyWasArrestedBefore = true;
					}
				}
				
				//if player drag monkey to its position, the 'monkeyIsOnShelf' still is true and this is not correct
				//we have have to check to see is monkey position.x is bigger than shelf and if 'monkeyIsOnShelf'= true
				//this mean monkey is send back by player and posBoolChange should be changed to false
				
				else 
				{
					Debug.Log ("monkey else if pos1Check.pos1IsFree == true && monkeyIsOnShelf == false");
					this.audio.Play();
					transform.position = monkeyBW.transform.position;
					monkeyIsOnShelf = false;
					CheckmonkeyBacktoPosition();
				}
			
			}
	
		}
		else 
		{
			Debug.Log ("monkey else if (transform.position.x < pauseBar.transform.position.x+2)");
			this.audio.Play();
			transform.position = monkeyBW.transform.position;
			monkeyIsOnShelf = false;
			CheckmonkeyBacktoPosition();
		}
		
	}
	
	void CheckmonkeyBacktoPosition()
	{
		if (setPosButtonScript.chaPos1 == "monkey")
		{
			Debug.Log ("setPosButtonScript.chaPos1 == monkey");
			//pos1Check.pos1BoolChange();
			pos1Check.pos1IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleNoCha();
			pauseEndScript.scaleNoCha();
			transform.position = monkeyBW.transform.position;
			monkeyIsOnShelf = false;
			setPosButtonScript.chaPos1 = "";
			checkLowerChaPos();
			
			if (monkeyWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(20000);
					handCuffs_monkey.renderer.enabled = true;
					PlayerPrefs.SetInt("monkeyArrested", 1);
					monkeyWasArrestedBefore = false;
				}



		}
		
		else if (setPosButtonScript.chaPos2 == "monkey")
		{
			Debug.Log ("setPosButtonScript.chaPos2 == monkey");
			//pos2Check.pos2BoolChange();
			pos2Check.pos2IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			transform.position = monkeyBW.transform.position;
			monkeyIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
			checkLowerChaPos();

			if (monkeyWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(20000);
					handCuffs_monkey.renderer.enabled = true;
					PlayerPrefs.SetInt("monkeyArrested", 1);
					monkeyWasArrestedBefore = false;
				}
			

		}
		
		else if (setPosButtonScript.chaPos3 == "monkey")
		{
			Debug.Log ("setPosButtonScript.chaPos3 == monkey");
			//pos3Check.pos3BoolChange();
			pos3Check.pos3IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			transform.position = monkeyBW.transform.position;
			monkeyIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
			checkLowerChaPos();

			if (monkeyWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(20000);
					handCuffs_monkey.renderer.enabled = true;
					PlayerPrefs.SetInt("monkeyArrested", 1);
					monkeyWasArrestedBefore = false;
				}
			

		}
		
		else if (setPosButtonScript.chaPos4 == "monkey")
		{
			Debug.Log ("setPosButtonScript.chaPos4 == monkey");
			//pos4Check.pos4BoolChange();
			pos4Check.pos4IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			transform.position = monkeyBW.transform.position;
			monkeyIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
			
			if (monkeyWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(20000);
					handCuffs_monkey.renderer.enabled = true;
					PlayerPrefs.SetInt("monkeyArrested", 1);
					monkeyWasArrestedBefore = false;
				}

		}
		
	}
	
	void checkLowerChaPos()
	{
		if (setPosButtonScript.chaPos2 != "" && setPosButtonScript.chaPos1 == "")
		{
			Debug.Log ("monkey setPosButtonScript.chaPos2 != null");
			string teamMemberName = setPosButtonScript.chaPos2;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos1.transform.position;
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			pos1Check.pos1IsFree = false;
			pos2Check.pos2IsFree = true;
			setPosButtonScript.chaPos1 = teamMemberName;
			monkeyIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
		}

		if (setPosButtonScript.chaPos3 != "" && setPosButtonScript.chaPos2 == "")
		{
			Debug.Log ("monkey setPosButtonScript.chaPos3 != null");
			string teamMemberName = setPosButtonScript.chaPos3;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos2.transform.position;
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			pos2Check.pos2IsFree = false;
			pos3Check.pos3IsFree = true;
			setPosButtonScript.chaPos2 = teamMemberName;
			monkeyIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
		}

		if (setPosButtonScript.chaPos4 != "" && setPosButtonScript.chaPos3 == "")
		{
			Debug.Log ("monkey setPosButtonScript.chaPos4 != null");
			string teamMemberName = setPosButtonScript.chaPos4;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos3.transform.position;
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			pos3Check.pos3IsFree = false;
			pos4Check.pos4IsFree = true;
			setPosButtonScript.chaPos3 = teamMemberName;
			monkeyIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
		}
	
	}
}

