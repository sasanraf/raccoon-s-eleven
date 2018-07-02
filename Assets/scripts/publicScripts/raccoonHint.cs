using UnityEngine;
using System.Collections;

public class raccoonHint : MonoBehaviour {

	int randomNoGen;
	Animator anim;
	// Use this for initialization
	public string currentLevelNameTutorial;
	void Start () 
	{
		anim = this.GetComponent<Animator>();
	}

	void OnMouseDown()
	{
		this.audio.Play();
		Time.timeScale=1;
		currentLevelNameTutorial = Application.loadedLevelName;
		PlayerPrefs.SetString("currentLevelNameTutorial",currentLevelNameTutorial);
		Application.LoadLevel("tutorial");
	}

	// Update is called once per frame
	void Update () 
	{
		randomNoGen = Random.Range(1, 400);
		if (randomNoGen == 5)
		{
			anim.SetBool("raccoonBlink", true);
			StartCoroutine(delay());
		}
	}
	IEnumerator delay() 
	{
		yield return new WaitForSeconds(.1f);
		anim.SetBool("raccoonBlink", false);
	}


}
