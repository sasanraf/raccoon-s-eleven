using UnityEngine;
using System.Collections;

public class rhino_chaPickLev09 : MonoBehaviour
{
	//mouse and screen 
	private Vector3 screenPoint;
	private float mouseX;
	private float mouseY;
	private Vector3 mouseposition;
	
	GameObject pauseBar;
	GameObject rhinoBW;

	GameObject dummyPos1;
	GameObject dummyPos2;
	GameObject dummyPos3;
	GameObject dummyPos4;

	GameObject hand;
	
	GameObject handCuffs_rhino;

	dummyChaMenuPos1 pos1Check;
	dummyChaMenuPos2 pos2Check;
	dummyChaMenuPos3 pos3Check;
	dummyChaMenuPos4 pos4Check;

	pauseBarScale pauseBarScript;
	pauseEndScale pauseEndScript;
	
	public bool rhinoIsOnShelf = false;

	bottunDone_TeamSelLev09 setPosButtonScript;

	moneyToBuy money;

	bool rhinoWasArrestedBefore = false;

	void Start ()
	{
		handCuffs_rhino = GameObject.Find("handCuffs_rhino");
		
		if (PlayerPrefs.GetInt("rhinoArrested") == 1)
		{
			handCuffs_rhino.renderer.enabled = true;
		}

		money = GameObject.Find ("scoreGUItext").GetComponent<moneyToBuy>();

		int totalScore = PlayerPrefs.GetInt("Player Score");
		if (totalScore < 10000)
		{
			Destroy (gameObject);
		}

		pauseBar = GameObject.Find ("pauseBar");
		rhinoBW = GameObject.Find ("rhinoBW");

		pauseBarScript = GameObject.Find ("pauseBar").GetComponent<pauseBarScale>();
		pauseEndScript = GameObject.Find ("pauseEnd").GetComponent<pauseEndScale>();

		setPosButtonScript = GameObject.Find ("bottunDone").GetComponent<bottunDone_TeamSelLev09>();

		dummyPos1 = GameObject.Find ("dummyPos1");
		dummyPos2 = GameObject.Find ("dummyPos2");
		dummyPos3 = GameObject.Find ("dummyPos3");
		dummyPos4 = GameObject.Find ("dummyPos4");

		hand = GameObject.Find ("hand");

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
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;

	}

	void OnMouseUp () 
	{
		if (transform.position.x < pauseBar.transform.position.x+2)
		{
			if (PlayerPrefs.GetInt("rhinoArrested") == 0 || 
			    (PlayerPrefs.GetInt("rhinoArrested") == 1  && ((money.moneyLeft - 30000) >= 0)))
			{
				if (pos1Check.pos1IsFree == true && rhinoIsOnShelf == false )
				{
					Debug.Log ("pos1Check.pos1IsFree == true && rhinoIsOnShelf == false");
					pauseBarScript.scaleOneCha();
					pauseEndScript.scaleOneCha();
					this.audio.Play();
					transform.position = dummyPos1.transform.position;

					pos1Check.pos1IsFree = false;
					rhinoIsOnShelf = true;
					setPosButtonScript.chaPos1 = "rhino";
					
					if (PlayerPrefs.GetInt("rhinoArrested") == 1)
					{
						money.audio.Play ();
						money.buy(30000);
						handCuffs_rhino.renderer.enabled = false;
						PlayerPrefs.SetInt("rhinoArrested", 0);
						rhinoWasArrestedBefore = true;
					}
					else
					{
						money.audio.Play ();
						money.buy(10000);
					}
				}

				else if (pos2Check.pos2IsFree == true && rhinoIsOnShelf == false && ((money.moneyLeft - 10000) >= 0))
				{
					Debug.Log ("rhino pos2Check.pos2IsFree == true && rhinoIsOnShelf == false");
					pauseBarScript.scaleTwoCha();
					pauseEndScript.scaleTwoCha();
					this.audio.Play();
					transform.position = dummyPos2.transform.position;

					pos2Check.pos2IsFree = false;
					rhinoIsOnShelf = true;
					setPosButtonScript.chaPos2 = "rhino";
					
					if (PlayerPrefs.GetInt("rhinoArrested") == 1)
					{
						money.audio.Play ();
						money.buy(30000);
						handCuffs_rhino.renderer.enabled = false;
						PlayerPrefs.SetInt("rhinoArrested", 0);
						rhinoWasArrestedBefore = true;
					}
					else
					{
						money.audio.Play ();
						money.buy(10000);
					}
					
				}

				else if (pos3Check.pos3IsFree == true && rhinoIsOnShelf == false && ((money.moneyLeft - 10000) >= 0))
				{
					Debug.Log ("rhino pos3Check.pos3IsFree == true && rhinoIsOnShelf == false");
					pauseBarScript.scaleThreeCha();
					pauseEndScript.scaleThreeCha();
					this.audio.Play();
					transform.position = dummyPos3.transform.position;

					pos3Check.pos3IsFree = false;
					rhinoIsOnShelf = true;
					setPosButtonScript.chaPos3 = "rhino";

					
					if (PlayerPrefs.GetInt("rhinoArrested") == 1)
					{
						money.audio.Play ();
						money.buy(30000);
						handCuffs_rhino.renderer.enabled = false;
						PlayerPrefs.SetInt("rhinoArrested", 0);
						rhinoWasArrestedBefore = true;
					}
					else
					{
						money.audio.Play ();
						money.buy(10000);
					}
					
				}

				else if (pos4Check.pos4IsFree == true && rhinoIsOnShelf == false && ((money.moneyLeft - 10000) >= 0))
				{
					Debug.Log ("rhino pos4Check.pos4IsFree == true && rhinoIsOnShelf == false");
					pauseBarScript.scaleFourCha();
					pauseEndScript.scaleFourCha();
					this.audio.Play();
					transform.position = dummyPos4.transform.position;

					pos4Check.pos4IsFree = false;
					rhinoIsOnShelf = true;
					setPosButtonScript.chaPos4 = "rhino";


					if (PlayerPrefs.GetInt("rhinoArrested") == 1)
					{
						money.audio.Play ();
						money.buy(30000);
						handCuffs_rhino.renderer.enabled = false;
						PlayerPrefs.SetInt("rhinoArrested", 0);
						rhinoWasArrestedBefore = true;
					}
					else
					{
						money.audio.Play ();
						money.buy(10000);
					}

				}

				//if player drag rhino to its position, the 'rhinoIsOnShelf' still is true and this is not correct
				//we have have to check to see is rhino position.x is bigger than shelf and if 'rhinoIsOnShelf'= true
				//this mean rhino is send back by player and posBoolChange should be changed to false

				else 
				{
					Debug.Log ("rhino else if pos1Check.pos1IsFree == true && rhinoIsOnShelf == false");
					this.audio.Play();
					transform.position = rhinoBW.transform.position;
					rhinoIsOnShelf = false;
					CheckRhinoBacktoPosition();
				}
			}
		}

		else 
		{
			Debug.Log ("rhino else if (transform.position.x < pauseBar.transform.position.x+2)");
			this.audio.Play();
			transform.position = rhinoBW.transform.position;
			rhinoIsOnShelf = false;
			CheckRhinoBacktoPosition();

		}

	}

	void CheckRhinoBacktoPosition()
	{
		if (setPosButtonScript.chaPos1 == "rhino")
		{
			Debug.Log ("setPosButtonScript.chaPos1 == rhino");
			//pos1Check.pos1BoolChange();
			pos1Check.pos1IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleNoCha();
			pauseEndScript.scaleNoCha();
			transform.position = rhinoBW.transform.position;
			rhinoIsOnShelf = false;
			setPosButtonScript.chaPos1 = "";
			checkLowerChaPos();
			
			if (rhinoWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(30000);
					handCuffs_rhino.renderer.enabled = true;
					PlayerPrefs.SetInt("rhinoArrested", 1);
					rhinoWasArrestedBefore = false;
				}
			else
				{
					money.audio.Play ();
					money.refund(10000);
				}
			


		}
		
		else if (setPosButtonScript.chaPos2 == "rhino")
		{
			Debug.Log ("setPosButtonScript.chaPos2 == rhino");
			//pos2Check.pos2BoolChange();
			pos2Check.pos2IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			transform.position = rhinoBW.transform.position;
			rhinoIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
			checkLowerChaPos();
			
			if (rhinoWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(30000);
					handCuffs_rhino.renderer.enabled = true;
					PlayerPrefs.SetInt("rhinoArrested", 1);
					rhinoWasArrestedBefore = false;
				}
			else
				{
					money.audio.Play ();
					money.refund(10000);
				}


		}
		
		else if (setPosButtonScript.chaPos3 == "rhino")
		{
			Debug.Log ("setPosButtonScript.chaPos3 == rhino");
			//pos3Check.pos3BoolChange();
			pos3Check.pos3IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			transform.position = rhinoBW.transform.position;
			rhinoIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
			checkLowerChaPos();
			
			if (rhinoWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(30000);
					handCuffs_rhino.renderer.enabled = true;
					PlayerPrefs.SetInt("rhinoArrested", 1);
					rhinoWasArrestedBefore = false;
				}
			else
				{
					money.audio.Play ();
					money.refund(10000);
				}


		}
		
		else if (setPosButtonScript.chaPos4 == "rhino")
		{
			Debug.Log ("setPosButtonScript.chaPos4 == rhino");
			//pos4Check.pos4BoolChange();
			pos4Check.pos4IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			transform.position = rhinoBW.transform.position;
			rhinoIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
			
			if (rhinoWasArrestedBefore == true)
				{
					money.audio.Play ();
					money.refund(30000);
					handCuffs_rhino.renderer.enabled = true;
					PlayerPrefs.SetInt("rhinoArrested", 1);
					rhinoWasArrestedBefore = false;
				}
			else
				{
					money.audio.Play ();
					money.refund(10000);
				}
		}

	}

	void checkLowerChaPos()
	{
		if (setPosButtonScript.chaPos2 != "" && setPosButtonScript.chaPos1 == "")
		{
			Debug.Log ("rhino setPosButtonScript.chaPos2 != null");
			string teamMemberName = setPosButtonScript.chaPos2;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos1.transform.position;
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			pos1Check.pos1IsFree = false;
			pos2Check.pos2IsFree = true;
			setPosButtonScript.chaPos1 = teamMemberName;
			rhinoIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
		}

		if (setPosButtonScript.chaPos3 != "" && setPosButtonScript.chaPos2 == "")
		{
			Debug.Log ("rhino setPosButtonScript.chaPos3 != null");
			string teamMemberName = setPosButtonScript.chaPos3;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos2.transform.position;
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			pos2Check.pos2IsFree = false;
			pos3Check.pos3IsFree = true;
			setPosButtonScript.chaPos2 = teamMemberName;
			rhinoIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
		}

		if (setPosButtonScript.chaPos4 != "" && setPosButtonScript.chaPos3 == "")
		{
			Debug.Log ("rhino setPosButtonScript.chaPos4 != null");
			string teamMemberName = setPosButtonScript.chaPos4;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos3.transform.position;
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			pos3Check.pos3IsFree = false;
			pos4Check.pos4IsFree = true;
			setPosButtonScript.chaPos3 = teamMemberName;
			rhinoIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
		}
	}
}








