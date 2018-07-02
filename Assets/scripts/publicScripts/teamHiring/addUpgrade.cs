using UnityEngine;
using System.Collections;

public class addUpgrade : MonoBehaviour {


	void OnMouseDown  () 
	{
		this.collider2D.enabled = false;
		this.renderer.enabled = false;
	}
}
