using UnityEngine;
using System.Collections;

public class timerRhino_Level_05 : MonoBehaviour {


	rhino_Level_05 rhinoScript;
	safeBoxExplosion_level05 explosionScript;
	timerSB_10seconds timerSB_10secondsScript;

	private GameObject highlightZebSafebox;
	private GameObject rhino;
	private GameObject SafeboxObject;	

	public bool rhinoFinishedSafebox = false;
	public bool timerRhinoIsWorking = false;

	Animator anim;
	
	void Start () 
	{
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		explosionScript = GameObject.Find ("explosion").GetComponent<safeBoxExplosion_level05>();	
		rhino = GameObject.Find ("rhino"); 
		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_05>();
		timerSB_10secondsScript = GameObject.Find("timerSB_10seconds").GetComponent<timerSB_10seconds>();		
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
