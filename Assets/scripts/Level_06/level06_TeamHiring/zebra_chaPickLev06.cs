using UnityEngine;
using System.Collections;

public class zebra_chaPickLev06 : MonoBehaviour {

	//mouse and screen 
	private Vector3 screenPoint;
	private float mouseX;
	private float mouseY;
	private Vector3 mouseposition;
	
	GameObject pauseBar;
	GameObject zebraBW;
	
	GameObject dummyPos1;
	GameObject dummyPos2;
	GameObject dummyPos3;
	GameObject dummyPos4;
	
	GameObject hand;
	
	dummyChaMenuPos1 pos1Check;
	dummyChaMenuPos2 pos2Check;
	dummyChaMenuPos3 pos3Check;
	dummyChaMenuPos4 pos4Check;
	
	pauseBarScale pauseBarScript;
	pauseEndScale pauseEndScript;
	
	public bool zebraIsOnShelf = false;
	
	bottunDone_TeamSelLev06 setPosButtonScript;
	
	moneyToBuy money;
	
	void Start ()
	{
		
		money = GameObject.Find ("scoreGUItext").GetComponent<moneyToBuy>();
		
		pauseBar = GameObject.Find ("pauseBar");
		zebraBW = GameObject.Find ("zebraBW");
		
		pauseBarScript = GameObject.Find ("pauseBar").GetComponent<pauseBarScale>();
		pauseEndScript = GameObject.Find ("pauseEnd").GetComponent<pauseEndScale>();
		
		setPosButtonScript = GameObject.Find ("bottunDone").GetComponent<bottunDone_TeamSelLev06>();
		
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
			if (pos1Check.pos1IsFree == true && zebraIsOnShelf == false)
			{
				Debug.Log ("zebra pos1Check.pos1IsFree == true && zebraIsOnShelf == false");
				pauseBarScript.scaleOneCha();
				pauseEndScript.scaleOneCha();
				this.audio.Play();
				transform.position = dummyPos1.transform.position;
				
				pos1Check.pos1IsFree = false;
				zebraIsOnShelf = true;
				setPosButtonScript.chaPos1 = "zebra";
				
				
			}
			
			else if (pos2Check.pos2IsFree == true && zebraIsOnShelf == false)
			{
				Debug.Log ("zebra pos2Check.pos2IsFree == true && zebraIsOnShelf == false");
				pauseBarScript.scaleTwoCha();
				pauseEndScript.scaleTwoCha();
				this.audio.Play();
				transform.position = dummyPos2.transform.position;
				
				pos2Check.pos2IsFree = false;
				zebraIsOnShelf = true;
				setPosButtonScript.chaPos2 = "zebra";
				
				
			}
			
			else if (pos3Check.pos3IsFree == true && zebraIsOnShelf == false)
			{
				Debug.Log ("zebra pos3Check.pos3IsFree == true && zebraIsOnShelf == false");
				pauseBarScript.scaleThreeCha();
				pauseEndScript.scaleThreeCha();
				this.audio.Play();
				transform.position = dummyPos3.transform.position;
				
				pos3Check.pos3IsFree = false;
				zebraIsOnShelf = true;
				setPosButtonScript.chaPos3 = "zebra";
				
				
			}
			
			else if (pos4Check.pos4IsFree == true && zebraIsOnShelf == false)
			{
				Debug.Log ("zebra pos4Check.pos4IsFree == true && zebraIsOnShelf == false");
				pauseBarScript.scaleFourCha();
				pauseEndScript.scaleFourCha();
				this.audio.Play();
				transform.position = dummyPos4.transform.position;
				
				pos4Check.pos4IsFree = false;
				zebraIsOnShelf = true;
				setPosButtonScript.chaPos4 = "zebra";
				
				
				
			}
			
			//if player drag zebra to its position, the 'zebraIsOnShelf' still is true and this is not correct
			//we have have to check to see is zebra position.x is bigger than shelf and if 'zebraIsOnShelf'= true
			//this mean zebra is send back by player and posBoolChange should be changed to false
			
			else 
			{
				Debug.Log ("zebra else if pos1Check.pos1IsFree == true && zebraIsOnShelf == false");
				this.audio.Play();
				transform.position = zebraBW.transform.position;
				zebraIsOnShelf = false;
				CheckzebraBacktoPosition();
			}
			
		}
		
		else 
		{
			Debug.Log ("zebra else if (transform.position.x < pauseBar.transform.position.x+2)");
			this.audio.Play();
			transform.position = zebraBW.transform.position;
			zebraIsOnShelf = false;
			CheckzebraBacktoPosition();
		}
		
	}
	
	void CheckzebraBacktoPosition()
	{
		if (setPosButtonScript.chaPos1 == "zebra")
		{
			Debug.Log ("setPosButtonScript.chaPos1 == zebra");
			//pos1Check.pos1BoolChange();
			pos1Check.pos1IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleNoCha();
			pauseEndScript.scaleNoCha();
			transform.position = zebraBW.transform.position;
			zebraIsOnShelf = false;
			setPosButtonScript.chaPos1 = "";
			
			
			checkLowerChaPos();
		}
		
		else if (setPosButtonScript.chaPos2 == "zebra")
		{
			Debug.Log ("setPosButtonScript.chaPos2 == zebra");
			//pos2Check.pos2BoolChange();
			pos2Check.pos2IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			transform.position = zebraBW.transform.position;
			zebraIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
			
			
			checkLowerChaPos();
		}
		
		else if (setPosButtonScript.chaPos3 == "zebra")
		{
			Debug.Log ("setPosButtonScript.chaPos3 == zebra");
			//pos3Check.pos3BoolChange();
			pos3Check.pos3IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			transform.position = zebraBW.transform.position;
			zebraIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
			
			
			checkLowerChaPos();
		}
		
		else if (setPosButtonScript.chaPos4 == "zebra")
		{
			Debug.Log ("setPosButtonScript.chaPos4 == zebra");
			//pos4Check.pos4BoolChange();
			pos4Check.pos4IsFree = true;
			this.audio.Play();
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			transform.position = zebraBW.transform.position;
			zebraIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
			
		}
		
	}
	
	void checkLowerChaPos()
	{
		if (setPosButtonScript.chaPos2 != "" && setPosButtonScript.chaPos1 == "")
		{
			Debug.Log ("zebra setPosButtonScript.chaPos2 != null");
			string teamMemberName = setPosButtonScript.chaPos2;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos1.transform.position;
			pauseBarScript.scaleOneCha();
			pauseEndScript.scaleOneCha();
			pos1Check.pos1IsFree = false;
			pos2Check.pos2IsFree = true;
			setPosButtonScript.chaPos1 = teamMemberName;
			zebraIsOnShelf = false;
			setPosButtonScript.chaPos2 = "";
		}

		if (setPosButtonScript.chaPos3 != "" && setPosButtonScript.chaPos2 == "")
		{
			Debug.Log ("zebra setPosButtonScript.chaPos3 != null");
			string teamMemberName = setPosButtonScript.chaPos3;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos2.transform.position;
			pauseBarScript.scaleTwoCha();
			pauseEndScript.scaleTwoCha();
			pos2Check.pos2IsFree = false;
			pos3Check.pos3IsFree = true;
			setPosButtonScript.chaPos2 = teamMemberName;
			zebraIsOnShelf = false;
			setPosButtonScript.chaPos3 = "";
		}

		if (setPosButtonScript.chaPos4 != "" && setPosButtonScript.chaPos3 == "")
		{
			Debug.Log ("zebra setPosButtonScript.chaPos4 != null");
			string teamMemberName = setPosButtonScript.chaPos4;
			GameObject teamMember =  GameObject.Find (teamMemberName);
			teamMember.transform.position = dummyPos3.transform.position;
			pauseBarScript.scaleThreeCha();
			pauseEndScript.scaleThreeCha();
			pos3Check.pos3IsFree = false;
			pos4Check.pos4IsFree = true;
			setPosButtonScript.chaPos3 = teamMemberName;
			zebraIsOnShelf = false;
			setPosButtonScript.chaPos4 = "";
		}

	}
}


