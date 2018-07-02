using UnityEngine;
using System.Collections;

public class moneyToBuy : MonoBehaviour {

	GameObject scoreBG;
	public int moneyLeft;
	GameObject addUpgrade;

	void Start () 
	{
		addUpgrade = GameObject.Find ("addUpgrade");

		/*UPGRADE ADD
		int addShow = Random.Range(1, 5);
		if (addShow == 2)
		{
			addUpgrade.renderer.enabled = true;
			addUpgrade.collider2D.enabled = true;
			addUpgrade.audio.Play();
		}
		*/

		moneyLeft = PlayerPrefs.GetInt("Player Score");

		guiText.text = ("$" + moneyLeft.ToString());

		int screenWidthX =  Screen.width;
		int screenHeightY =  Screen.height;
	
		scoreBG = GameObject.Find ("scoreBG");

		Vector3 scoreBGPos = Camera.main.WorldToScreenPoint (scoreBG.transform.position);
		float scoreBGPos_x = (scoreBGPos.x/screenWidthX);
		float scoreBGPos_y = (scoreBGPos.y/screenHeightY);
		
		this.transform.position = new Vector3(scoreBGPos_x,scoreBGPos_y,0);
		guiText.fontSize = (int) (Screen.width * 0.04f);
	}
	

	public void buy(int chaPrice) 
	{
		moneyLeft = moneyLeft - chaPrice;
		StartCoroutine(delayCounter());
	}

	public void refund(int chaPrice) 
	{
		moneyLeft = moneyLeft + chaPrice;
		StartCoroutine(delayCounter());
	}
	
	IEnumerator delayCounter() 
	{
		for (int scoreCounter = (moneyLeft-25); scoreCounter < (moneyLeft+1); scoreCounter++)
		{
			yield return new WaitForSeconds(.00001f);
			guiText.text = ("$" + scoreCounter.ToString());
		}
	}
}
