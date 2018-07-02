using UnityEngine;
using System.Collections;

public class comments : MonoBehaviour {

	public string commentsTexts = "Please write your comment(s) here: ";
	int screenWidthX;
	int screenHeightY;

	void Start () 
	{

	screenWidthX =  Screen.width;
	screenHeightY =  Screen.height;
	}

	void OnGUI() 
	{
		GUIStyle myTextStyle = new GUIStyle(GUI.skin.textArea);
		myTextStyle.fontSize = (int) (Screen.width * 0.04f);
		myTextStyle.alignment = TextAnchor.UpperLeft;

		commentsTexts = GUI.TextArea(new Rect(10, 10, screenWidthX-20, screenHeightY-70), commentsTexts, 950, myTextStyle);
	}

}
