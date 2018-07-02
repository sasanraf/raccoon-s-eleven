using UnityEngine;
using System.Collections;

public class screenSwap : MonoBehaviour {

	Vector3 screenPoint;
	float mouseX;
	float mouseY;
	Vector3 mouseposition;
	Vector3 lastPos;
	Vector3 currentScreenPoint;
	Vector3 currentPos;

	int choice = 1;
	
	page01 page01;
	page02 page02;
	page03 page03;
	page04 page04;

	bool newTouch = true;

	void Start () 
	{
		page01 = GameObject.Find ("intro_1").GetComponent<page01>();
		page02 = GameObject.Find ("intro_2").GetComponent<page02>();
		page03 = GameObject.Find ("intro_3").GetComponent<page03>();
		page04 = GameObject.Find ("intro_4").GetComponent<page04>();
	}
	
	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		lastPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
	}
	
	
	void OnMouseDrag()  
	{		
		currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		if (lastPos.x > currentPos.x && newTouch == true )
		{			
			switch(choice)
			{
			case 1: 
				page01.move();
				newTouch = false;
				transform.position = new Vector3(0,0,0);
				break;
				
			case 2: 
				page02.move();
				newTouch = false;
				transform.position = new Vector3(0,0,0);
				break;
				
			case 3: 
				page03.move();
				newTouch = false;
				transform.position = new Vector3(0,0,0);
				break;
				
			case 4: 
				page04.move();
				newTouch = false;
				transform.position = new Vector3(0,0,0);
				break;
				
			case 5: 
				Application.LoadLevel("mainMenu");
				break;
			}


		}	
	}

	void OnMouseUp()
	{
		newTouch = true;
		choice += 1;
	}
		

}
