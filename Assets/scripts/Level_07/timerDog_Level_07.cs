using UnityEngine;
using System.Collections;

public class timerDog_Level_07 : MonoBehaviour 
{


	Animator anim;
	
	void Start () 
	{
	
		anim = this.GetComponent<Animator>();
	}
	
	public void dogFightStart()  
	{
		renderer.enabled = true;
		//anim.SetBool("dogFight", true);	
		StartCoroutine("waitOnPlay");
	}
	
	IEnumerator waitOnPlay() 
	{
		yield return new WaitForSeconds(10.0f);
		dogFightEnd();
	}
	
	
	public void dogFightEnd()  
	{
		renderer.enabled = false;
		//anim.SetBool("dogFight", false);
	}
}