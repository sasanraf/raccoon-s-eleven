using UnityEngine;
using System.Collections;

public class cameraZoonChange : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		transform.position = new Vector3(0,0,-10);
	}

	public void movetoZoon1 ()
	{
		anim.SetInteger("zoonChanged", 1);
	}

	public void movetoZoon2 ()
	{
		anim.SetInteger("zoonChanged", 2);
	}

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			Application.Quit();
		}
	}



}
