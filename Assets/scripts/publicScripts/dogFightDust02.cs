using UnityEngine;
using System.Collections;

public class dogFightDust02 : MonoBehaviour {

	Animator anim;
	public bool dogIsFighting = false;

	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
	}
	
	public void dogFightingStart()  
	{
		dogIsFighting = true;
		renderer.enabled = true;
		anim.SetBool("dogFighting", true);
		audio.Play();
		StartCoroutine(waitOnPlay());
	}

	IEnumerator waitOnPlay() 
	{
		yield return new WaitForSeconds(10);
		dogFightingStop();
	}

	public void dogFightingStop()  
	{
		anim.SetBool("dogFighting", false);	
		renderer.enabled = false;
		dogIsFighting = false;
	}
}
