using UnityEngine;
using System.Collections;

public class safeBoxExplosion_level07 : MonoBehaviour 
{
	rhino_Level_07 rhinoScript;
	Animator anim;
	
	private GameObject safeBoxObjectopened;
	private GameObject safeBoxObject;
	private GameObject  moneySafebox;
	//private GameObject explosion;

	GameObject dog;
	gorilla_Level_07 gorillaScript;

	private Camera camera;
	Vector3 cameraPos;
	cameraZoonChange cameraShakeScript;
	
	void Start () 
	{

		dog = GameObject.Find ("dog");
		gorillaScript = GameObject.Find("gorilla").GetComponent<gorilla_Level_07>();

		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_07>();
		anim = this.GetComponent<Animator>();
		
		safeBoxObject = GameObject.Find ("safeBox");
		safeBoxObjectopened = GameObject.Find ("safeBoxOpened");
		
		moneySafebox = GameObject.Find ("moneySafebox");
		
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
			Destroy (safeBoxObject);
			safeBoxObjectopened.renderer.enabled = true;
			moneySafebox.renderer.enabled = true;
		}
		
		
		
	}
	
}
