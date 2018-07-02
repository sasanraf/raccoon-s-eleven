using UnityEngine;
using System.Collections;

public class pauseGame : MonoBehaviour 
{
	levelSelection levelSelectionScript;
	exitGame exitGameScript;
	mainMenu mainMenuScript;
	refreshGame refreshGameScript;
	pauseBarHorizontal pauseBarScript;
	public bool pauseEnable = false;

	GameObject timerBG;
	GameObject timerGUIText;

	
	void Start () 
	{

		mainMenuScript = GameObject.Find ("mainMenuButton").GetComponent<mainMenu>();
		levelSelectionScript = GameObject.Find ("levelSelectionButton").GetComponent<levelSelection>();
		refreshGameScript = GameObject.Find ("refreshButton").GetComponent<refreshGame>();
		exitGameScript = GameObject.Find ("exitButton").GetComponent<exitGame>();
		pauseBarScript = GameObject.Find ("pauseBarHorizontal").GetComponent<pauseBarHorizontal>();

		timerBG = GameObject.Find ("timerBG");
		timerGUIText = GameObject.Find ("timerGUIText");
	}

	void OnMouseDown  () 
	{
		this.audio.Play();
		pauseTheGame();
	}
		
	public void pauseTheGame () 
	{
		pauseEnable = !pauseEnable;

		if (pauseEnable == true)
		{
			if (timerBG)
			{
				timerBG.renderer.enabled = false;
			}
			if (timerGUIText)
			{
				timerGUIText.guiText.enabled = false;
			}

			mainMenuScript.moveMainMenu(true);
			levelSelectionScript.movelevelSelection(true);
			refreshGameScript.moveRefresh(true);
			exitGameScript.moveExit(true);
			pauseBarScript.pauseBar(true);

			StartCoroutine("delay");
		}
		else
		{
			if (timerBG)
			{
				timerBG.renderer.enabled = true;
			}
			if (timerGUIText)
			{
				timerGUIText.guiText.enabled = true;
			}
			Time.timeScale=1;
			mainMenuScript.moveMainMenu(false);
			levelSelectionScript.movelevelSelection(false);
			refreshGameScript.moveRefresh(false);
			exitGameScript.moveExit(false);
			pauseBarScript.pauseBar(false);
		}


	}

	IEnumerator delay() 
	{
		yield return new WaitForSeconds(.5f);
		Time.timeScale=0;
	}

 

}