using UnityEngine;
using System.Collections;

public class timerRhino_Level_10 : MonoBehaviour {

	rhino_Level_10 rhinoScript;
	
	safeBoxExplosion_level10 explosionScript;
	timerSB_10seconds timerSB_10secondsScript;
	
	safeBoxExplosion02_level10 explosion02Script;
	timerSB02_10seconds timerSB02_10secondsScript;
	
	safeBoxExplosion03_level10 explosion03Script;
	timerSB03_10seconds timerSB03_10secondsScript;

	GameObject highlightZebSafebox;
	GameObject highlightZebSafebox02;
	GameObject highlightZebSafebox03;
	
	GameObject rhino;
	
	GameObject SafeboxObject;	
	GameObject SafeboxObject02;	
	GameObject SafeboxObject03;	
	
	public bool rhinoFinishedSafebox = false;
	public bool rhinoFinishedSafebox02 = false;
	public bool rhinoFinishedSafebox03 = false;
	public bool timerRhinoIsWorking = false;

	Animator anim;
	
	void Start () 
	{
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");		
		highlightZebSafebox03 = GameObject.Find ("highlightZebSafebox03");
		explosionScript = GameObject.Find ("explosion").GetComponent<safeBoxExplosion_level10>();	
		explosion02Script = GameObject.Find ("explosion02").GetComponent<safeBoxExplosion02_level10>();
		explosion03Script = GameObject.Find ("explosion03").GetComponent<safeBoxExplosion03_level10>();
		rhino = GameObject.Find ("rhino"); 
		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_10>();
		timerSB_10secondsScript = GameObject.Find("timerSB_10seconds").GetComponent<timerSB_10seconds>();	
		timerSB02_10secondsScript = GameObject.Find("timerSB02_10seconds").GetComponent<timerSB02_10seconds>();	
		timerSB03_10secondsScript = GameObject.Find("timerSB03_10seconds").GetComponent<timerSB03_10seconds>();		
		anim = this.GetComponent<Animator>();

	}
	
	public void timerOn()  
	{
		renderer.enabled = true;
		anim.SetBool("timerRhinoStart", true);
		timerRhinoIsWorking = true;
		StartCoroutine("waitOnPlay");
	}
	
	IEnumerator waitOnPlay() 
	{
		yield return new WaitForSeconds(10.0f);
		
		if (rhinoScript.rhinoIsInside == true && highlightZebSafebox == true && rhino.transform.position == highlightZebSafebox.transform.position)
		{
			rhinoFinishedSafebox = true;
			timerSB_10secondsScript.timerUnhide();
			explosionScript.explosion();
			timeroff();
		}
		
		if (rhinoScript.rhinoIsInside == true && highlightZebSafebox02 == true && rhino.transform.position == highlightZebSafebox02.transform.position)
		{
			rhinoFinishedSafebox02 = true;
			timerSB02_10secondsScript.timerUnhide();
			explosion02Script.explosion();
			timeroff();
		}		
		
		if (rhinoScript.rhinoIsInside == true && highlightZebSafebox03 == true && rhino.transform.position == highlightZebSafebox03.transform.position)
		{
			rhinoFinishedSafebox03 = true;
			timerSB03_10secondsScript.timerUnhide();
			explosion03Script.explosion();
			timeroff();
		}	

		else
		{
			timeroff();
		}
	}	
	
	public void timeroff()  
	{
		renderer.enabled = false;
		anim.SetBool("timerRhinoStart", false);
		timerRhinoIsWorking = false;		
	}

}
