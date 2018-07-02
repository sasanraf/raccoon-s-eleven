using UnityEngine;
using System.Collections;

public class gameTimer_Level_10_prw : MonoBehaviour 
{
	float levelTimer = 10f;
	string currentLevelName;

	GameObject timerBGObject;
	
	void Start () 
	{
		guiText.text = ("Time left: " + levelTimer.ToString("f0"));

		timerBGObject = GameObject.Find ("timerBG");

		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;
		Vector3 ScreenToPointConvertion = Camera.main.ScreenToWorldPoint(new Vector3(screenWidthX, screenHeightY, 0));
		Debug.Log (ScreenToPointConvertion);
		Vector3 timerBGPos = Camera.main.WorldToScreenPoint (timerBGObject.transform.position);
		float timerPos_x = (timerBGPos.x/screenWidthX);
		float timerPos_y = (timerBGPos.y/screenHeightY);

		this.transform.position = new Vector3(timerPos_x ,timerPos_y-0.01f, 0);		

		guiText.fontSize = (int) (Screen.width * 0.05f);		
	}
	
	void Update () 
	{
		
		levelTimer -= Time.deltaTime;
		guiText.text = (levelTimer.ToString("f0"));
	
		if (levelTimer <= 0)
		{	
		Application.LoadLevel("teamHiringLev10");
		}
	}


}

