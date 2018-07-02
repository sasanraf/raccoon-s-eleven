using UnityEngine;
using System.Collections;

public class gorilla_chaPickLev07 : MonoBehaviour {

	//mouse and screen 
	private Vector3 screenPoint;
	private float mouseX;
	private float mouseY;
	private Vector3 mouseposition;
	
	GameObject pauseBar;
	GameObject gorillaBW;
	
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
	
	public bool gorillaIsOnShelf = false;
	
	bottunDone_TeamSelLev07 setPosButtonScript;
	
	moneyToBuy money;

	GameObject gorillaInfo;

	
	void Start ()
	{
		gorillaInfo = GameObject.Find ("gorillaInfo");
		int totalScore = PlayerPrefs.GetInt("Player Score");
		if (totalScore < 20000)
		{
			Destroy (gameObject);
		}

		money = GameObject.Find ("scoreGUItext").GetComponent<moneyToBuy>();
		
		pauseBar = GameObject.Find ("pauseBar");
		gorillaBW = GameObject.Find ("gorillaBW");
		
		pauseBarScript = GameObject.Find ("pauseBar").GetComponent<pauseBarScale>();
		pauseEndScript = GameObject.Find ("pauseEnd").GetComponent<pauseEndScale>();
		
		setPosButtonScript = GameObject.Find ("bottunDone").GetComponent<bottunDone_TeamSelLev07>();
		
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
		gorillaInfo.renderer.enabled = true;
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;		
	}
	
	void OnMouseUp () 
	{
		gorillaInfo.renderer.enabled = false;
		if (transform.position.x < pauseBar.transform.position.x+2)
		{
			if (pos1Check.pos1IsFree == true && gorillaIsOnShelf == false && ((money.moneyLeft - 20000) >= 0) )
			{
				Debug.Log ("pos1Check.pos1IsFree == true && gorillaIsOnShelf == false");
				pauseBarScript.scaleOneCha();
				pauseEndScript.scaleOneCha();
				this.audio.Play();
				transform.position = dummyPos1.transform.position;
				
				pos1Check.pos1IsFree = false;
				gorillaIsOnShelf = true;
				setPosButtonScript.chaPos1 = "gorilla";
				
				money.audio.Play ();
				money.buy(20000);
				
			}
			
			else if (pos2Check.pos2IsFree == true && gorillaIsOnShelf == false && ((money.moneyLeft - 20000) >= 0))
			{
				Debug.Log ("gorilla pos2Check.pos2IsFree == true && gorillaIsOnShelf == false");
				pauseBarScript.scaleTwoCha();
				pauseEndScript.scaleTwoCha();
				this.audio.Play();
				transform.position = dummyPos2.transform.position;
				
				pos2Check.pos2IsFree = false;
				gorillaIsOnShelf = true;
				setPosButtonScript.chaPos2 = "gorilla";
				
				money.audio.Play ();
				money.buy(20000);
				
			}
			
			else if (pos3Check.pos3IsFree == true && gorillaIsOnShelf == false && ((money.moneyLeft - 20000) >= 0))
			{
				Debug.Log ("gorilla pos3Check.pos3IsFree == true && gorillaIsOnShelf == false");
				pauseBarScript.scaleThreeCha();
				pauseEndScript.scaleThreeCha();
				this.audio.Play();
				transform.position = dummyPos3.transform.position;
				
				pos3Check.pos3IsFree = false;
				gorillaIsOnShelf = true;
				setPosButtonScript.chaPos3 = "gorilla";
				
				money.audio.Play ();
				money.buy(20000);
				
			}
			
			else if (pos4Check.pos4IsFree == true && gorillaIsOnShelf == false && ((money.moneyLeft - 20000) >= 0))
			{
				Debug.Log ("gorilla pos4Check.pos4IsFree == true && gorillaIsOnShelf == false");
				pauseBarScript.scaleFourCha();
				pauseEndScript.scaleFourCha();
				this.audio.Play();
				transform.position = dummyPos4.transform.position;
				
				pos4Check.pos4IsFree = false;
				gorillaIsOnShelf = true;
				setPosButtonScript.chaPos4 = "gorilla";
				
				money.audio.Play ();
				money.buy(20000);
				
			}
			
			//if player drag gorilla to its position, the 'gorillaIsOnShelf' still is true and this is not correct
			//we have have to check to see is gorilla position.x is bigger than shelf and if 'gorillaIsOnShelf'= true
			//this mean gorilla is send back by player and posBoolChange should be changed to false
			
			else 
			{
				Debug.Log ("gorilla else if pos1Check.pos1IsFree == true && gorillaIsOnShelf == false");
				this.audio.Play();
				transform.position = gorillaBW.transform.position;
				gorillaIsOnShelf = false;
				CheckgorillaBacktoPosition();
			}
			
		}
		
		else 
		{
			Debug.Log ("gorilla else if (transform.position.x < pauseBar.transform.position.x+2)");
			this.audio.Play();
			transform.position = gorillaBW.transform.position;
			gorillaIsOnShelf = false;
			CheckgorillaBacktoPosition();
		}
		
	}
	
	void CheckgorillaBacktoPosition()
	{
		if (setPosButtonScript.chaPos1 == "gorilla")
		{
			Debug.Log ("setPosButtonScript.chaPos1 == gorilla");
			//pos1Check.pos1BoolChange();
			pos1Check.pos1IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleNoCha();
			pauseEndScript.scaleNoCha();
			transform.position = gorillaBW.transform.position;
			gorillaIsOnShelf = false;
			setPosButtonScript.chaPos1 = "";
			money.audio.Play ();
			money.refund(20000);
			
			checkLowerChaPos();
		}
		
		else if (setPosButtonScript.chaPos2 == "gorilla")
		{
			Debug.Log ("setPosButtonScript.chaPos2 == gorilla");
			//pos2Check.pos2BoolChange();
			pos2Check.pos2IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			transform.position = gorillaBW.transform.position;
			gorillaIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
			money.audio.Play ();
			money.refund(10000);
			
			checkLowerChaPos();
		}
		
		else if (setPosButtonScript.chaPos3 == "gorilla")
		{
			Debug.Log ("setPosButtonScript.chaPos3 == gorilla");
			//pos3Check.pos3BoolChange();
			pos3Check.pos3IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			transform.position = gorillaBW.transform.position;
			gorillaIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
			money.audio.Play ();
			money.refund(10000);
			
			checkLowerChaPos();
		}
		
		else if (setPosButtonScript.chaPos4 == "gorilla")
		{
			Debug.Log ("setPosButtonScript.chaPos4 == gorilla");
			//pos4Check.pos4BoolChange();
			pos4Check.pos4IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			transform.position = gorillaBW.transform.position;
			gorillaIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
			money.audio.Play ();
			money.refund(10000);
		}
		
	}
	
	void checkLowerChaPos()
	{
		if (setPosButtonScript.chaPos2 != "" && setPosButtonScript.chaPos1 == "")
		{
			Debug.Log ("gorilla setPosButtonScript.chaPos2 != null");
			string teamMemberName = setPosButtonScript.chaPos2;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos1.transform.position;
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			pos1Check.pos1IsFree = false;
			pos2Check.pos2IsFree = true;
			setPosButtonScript.chaPos1 = teamMemberName;
			gorillaIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
		}
		
		if (setPosButtonScript.chaPos3 != "" && setPosButtonScript.chaPos2 == "")
		{
			Debug.Log ("gorilla setPosButtonScript.chaPos3 != null");
			string teamMemberName = setPosButtonScript.chaPos3;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos2.transform.position;
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			pos2Check.pos2IsFree = false;
			pos3Check.pos3IsFree = true;
			setPosButtonScript.chaPos2 = teamMemberName;
			gorillaIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
		}
		
		if (setPosButtonScript.chaPos4 != "" && setPosButtonScript.chaPos3 == "")
		{
			Debug.Log ("gorilla setPosButtonScript.chaPos4 != null");
			string teamMemberName = setPosButtonScript.chaPos4;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos3.transform.position;
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			pos3Check.pos3IsFree = false;
			pos4Check.pos4IsFree = true;
			setPosButtonScript.chaPos3 = teamMemberName;
			gorillaIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
		}
	}

	void OnMouseExit()
	{
		gorillaInfo.renderer.enabled = false;
	}

}



