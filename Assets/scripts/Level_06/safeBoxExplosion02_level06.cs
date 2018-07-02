using UnityEngine;
using System.Collections;

public class safeBoxExplosion02_level06 : MonoBehaviour 
{
	rhino_Level_06 rhinoScript;
	Animator anim;
	
	private GameObject safeBoxObjectopened02;
	private GameObject safeBoxObject02;
	private GameObject  moneySafebox02;
	//private GameObject explosion;
	
	private Camera camera;
	Vector3 cameraPos;
	cameraZoonChange cameraShakeScript;
	
	void Start () 
	{
		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_06>();
		anim = this.GetComponent<Animator>();
		
		safeBoxObject02 = GameObject.Find ("safeBox02");
		safeBoxObjectopened02 = GameObject.Find ("safeBoxOpened02");
		
		moneySafebox02 = GameObject.Find ("moneySafebox02");
		
		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		cameraShakeScript = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange>();
		cameraPos = camera.transform.position;			
	}
	
	public void explosion () 
	{	
		if (rhinoScript.rhinoIsInside == true)
		{
			renderer.enabled = true;
			anim.SetBool("exploded", true);
			this.audio.Play();
			Handheld.Vibrate();
			StartCoroutine (explodeDelay());
		}
	}
	
	IEnumerator explodeDelay()
	{
		if (rhinoScript.rhinoIsInside == true)
		{
			yield return new WaitForSeconds (.13f);
			Destroy (safeBoxObject02);
			safeBoxObjectopened02.renderer.enabled = true;
			moneySafebox02.renderer.enabled = true;
		}
		
	}
	
}
