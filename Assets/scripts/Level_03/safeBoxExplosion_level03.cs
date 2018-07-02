using UnityEngine;
using System.Collections;

public class safeBoxExplosion_level03 : MonoBehaviour 
{
	rhino_Level_03 rhinoScript;
	Animator anim;
	
	private GameObject safeBoxObjectopened;
	private GameObject safeBoxObject;
	private GameObject  moneySafebox;
	//private GameObject explosion;

	private Camera camera;
	Vector3 cameraPos;
		
	void Start () 
	{
		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_03>();
		anim = this.GetComponent<Animator>();

		safeBoxObject = GameObject.Find ("safeBox");
		safeBoxObjectopened = GameObject.Find ("safeBoxOpened");
	
		moneySafebox = GameObject.Find ("moneySafebox");

		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
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
		cameraPos.y += 0.3f;
		camera.transform.position = cameraPos;
		yield return new WaitForSeconds (.1f);
		cameraPos.y += -.6f;
		camera.transform.position = cameraPos;
		yield return new WaitForSeconds (.05f);
		cameraPos.y += 0.3f;
		camera.transform.position = cameraPos;

		yield return new WaitForSeconds (.13f);
		Destroy (safeBoxObject);
		safeBoxObjectopened.renderer.enabled = true;
		moneySafebox.renderer.enabled = true;
		}



	}

}
