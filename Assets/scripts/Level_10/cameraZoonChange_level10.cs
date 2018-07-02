using UnityEngine;
using System.Collections;

public class cameraZoonChange_level10 : MonoBehaviour {

	Animator anim;
	
	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
		transform.position = new Vector3(0,0,-10);
	}
	
	public void movetoZoon12 ()
	{
		anim.SetInteger("cameraZoonChange", 12);
	}
	
	public void movetoZoon21 ()
	{
		anim.SetInteger("cameraZoonChange", 21);
	}
	
	public void movetoZoon13 ()
	{
		anim.SetInteger("cameraZoonChange", 13);
	}
	
	public void movetoZoon31 ()
	{
		anim.SetInteger("cameraZoonChange", 31);
	}

	public void movetoZoon34 ()
	{
		anim.SetInteger("cameraZoonChange", 34);
	}

	public void movetoZoon43 ()
	{
		anim.SetInteger("cameraZoonChange", 43);
	}
	
	public void movetoZoon24 ()
	{
		anim.SetInteger("cameraZoonChange", 24);
	}
	
	public void movetoZoon42 ()
	{
		anim.SetInteger("cameraZoonChange", 42);
	}

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			Application.Quit();
		}
	}
	
}

