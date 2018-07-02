using UnityEngine;
using System.Collections;

public class endResult : MonoBehaviour {

	GameObject starFull01;
	GameObject starFull02;
	GameObject starFull03;
	GameObject starEmpty01;
	GameObject starEmpty02;
	GameObject starEmpty03;

	GameObject BGleftPart;
	GameObject BGrightPart;
	GameObject dollorSign;
	GameObject levelSelectionEndRes;
	GameObject nextLevelEndRes;
	GameObject refreshEndRes;

	GameObject pauseDisable;
	
	// Use this for initialization
	void Start () 
	{
		starFull01 = GameObject.Find ("starFull01");
		starFull02 = GameObject.Find ("starFull02");
		starFull03 = GameObject.Find ("starFull03");
		starEmpty01 = GameObject.Find ("starEmpty01");
		starEmpty02 = GameObject.Find ("starEmpty02");
		starEmpty03 = GameObject.Find ("starEmpty03");

		BGleftPart = GameObject.Find ("BGleftPart");
		BGrightPart = GameObject.Find ("BGrightPart");
		dollorSign = GameObject.Find ("dollorSign");
		levelSelectionEndRes = GameObject.Find ("levelSelectionEndRes");
		nextLevelEndRes = GameObject.Find ("nextLevelEndRes");
		refreshEndRes = GameObject.Find ("refreshEndRes");

		pauseDisable = GameObject.Find ("pause");
	}
	// Update is called once per frame
	public void showResult (int starsCount) 
	{

		pauseDisable.collider2D.enabled = false;

		Time.timeScale = 0;

		levelSelectionEndRes.collider2D.enabled = true;
		nextLevelEndRes.collider2D.enabled = true;
		refreshEndRes.collider2D.enabled = true;

		BGleftPart.renderer.enabled = true;
		BGrightPart.renderer.enabled = true;
		dollorSign.renderer.enabled = true;
		levelSelectionEndRes.renderer.enabled = true;
		nextLevelEndRes.renderer.enabled = true;
		refreshEndRes.renderer.enabled = true;

		starEmpty01.renderer.enabled = true;
		starEmpty02.renderer.enabled = true;
		starEmpty03.renderer.enabled = true;

		if (starsCount == 1)
		{
			starFull01.renderer.enabled = true;
		}
		
		if (starsCount == 2)
		{
			starFull01.renderer.enabled = true;
			starFull02.renderer.enabled = true;
		}
		
		if (starsCount == 3)
		{
			starFull01.renderer.enabled = true;
			starFull02.renderer.enabled = true;
			starFull03.renderer.enabled = true;
		}
	}
}
