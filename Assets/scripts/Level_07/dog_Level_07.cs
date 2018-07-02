using UnityEngine;
using System.Collections;

public class dog_Level_07 : MonoBehaviour {

	Animator anim;

	dogFightDust dogFightDustScript;

	gorilla_Level_07 gorillaScript;

	float dogSpeed = 1f;
	public bool dogWalked = false;
	bool monkeyArrested = false;
	bool rhinoArrested = false;

	GameObject monkey;
	GameObject zebra;
	GameObject rhino;
	
	monkey_Level_07 monkeyScript;
	zebra_Level_07 zebraScript;
	rhino_Level_07 rhinoScript;
	
	//highlight zebra
	GameObject highlightZebMeercat01;
	GameObject highlightZebRabbit01;
	GameObject highlightZebRabbit02;
	GameObject highlightZebRabbit03;
	GameObject highlightZebRabbit04;	
	GameObject highlightZebTeller01;
	GameObject highlightZebTeller02;
	GameObject highlightZebTeller03;
	GameObject highlightZebTeller04;
	GameObject highlightZebTeller05;
	GameObject highlightZebTeller06;
	GameObject highlightZebSafebox;
	GameObject highlightZebSafebox02;
	GameObject dogLimitArea;

	void Start ()
	{
		monkeyScript = GameObject.Find("monkey").GetComponent<monkey_Level_07>();
		zebraScript = GameObject.Find("zebra").GetComponent<zebra_Level_07>();
		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_07>();
		gorillaScript = GameObject.Find("gorilla").GetComponent<gorilla_Level_07>();

		dogFightDustScript = GameObject.Find("dogFightDust").GetComponent<dogFightDust>();

		monkey= GameObject.Find("monkey");	
		zebra = GameObject.Find("zebra");
		rhino = GameObject.Find("rhino");
		dogLimitArea = GameObject.Find("dogLimitArea");

		anim = this.GetComponent<Animator>();
		
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebRabbit01 = GameObject.Find ("highlightZebRabbit01");
		highlightZebRabbit02 = GameObject.Find ("highlightZebRabbit02");
		highlightZebRabbit03 = GameObject.Find ("highlightZebRabbit03");
		highlightZebRabbit04 = GameObject.Find ("highlightZebRabbit04");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller02 = GameObject.Find ("highlightZebTeller02");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		highlightZebTeller04 = GameObject.Find ("highlightZebTeller04");
		highlightZebTeller05 = GameObject.Find ("highlightZebTeller05");
		highlightZebTeller06 = GameObject.Find ("highlightZebTeller06");
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");
	
	}

	void Update () 
	{
		if (monkey && monkeyScript.monkeyIsInside == true && gorillaScript.gorillaIsInside == false 
		    && monkey.transform.position.x > dogLimitArea.transform.position.x && dogFightDustScript.dogIsFighting == false)
			{
				anim.SetBool("dogWalk", true);
				transform.position = Vector3.MoveTowards(transform.position, monkey.transform.position, dogSpeed * Time.deltaTime);
				dogWalked = true;

				if (transform.position.x >= monkey.transform.position.x)
				{
					transform.localScale = new Vector3(1f,1f,1);
				}
				else
				{
					transform.localScale = new Vector3(-1f,1f,1);
				}

				if (transform.position == monkey.transform.position)
				{
					PlayerPrefs.SetInt("monkeyArrested", 1);
					monkeyScript.monkeyIsInside = false;
					monkey.active = false;
					monkeyArrested = true;
					anim.SetBool("dogWalk", false);	
					dogFightDustScript.dogFightingStart();

					if (highlightZebMeercat01)
					{
						Destroy (highlightZebMeercat01);
					}
					if (highlightZebRabbit01)
					{
						Destroy (highlightZebRabbit01);
					}
					if (highlightZebRabbit02)
					{
						Destroy (highlightZebRabbit02);
					}
					if (highlightZebRabbit03)
					{
						Destroy (highlightZebRabbit03);
					}
					if (highlightZebRabbit04)
					{
						Destroy (highlightZebRabbit04);
					}
					if (highlightZebTeller01)
					{
						Destroy (highlightZebTeller01);
					}
					if (highlightZebTeller02)
					{
						Destroy (highlightZebTeller02);
					}
					if (highlightZebTeller03)
					{
						Destroy (highlightZebTeller03);
					}
					if (highlightZebTeller04)
					{
						Destroy (highlightZebTeller04);
					}
					if (highlightZebTeller05)
					{
						Destroy (highlightZebTeller05);
					}
					if (highlightZebTeller06)
					{
						Destroy (highlightZebTeller06);
					}
				}

			}

		else if (zebra && zebraScript.zebraIsInside == true && gorillaScript.gorillaIsInside == false
		         && zebra.transform.position.x > dogLimitArea.transform.position.x && dogFightDustScript.dogIsFighting == false)
		{
			anim.SetBool("dogWalk", true);
			transform.position = Vector3.MoveTowards(transform.position, zebra.transform.position, dogSpeed * Time.deltaTime);

			if (transform.position.x >= zebra.transform.position.x)
			{
				transform.localScale = new Vector3(1f,1f,1);
			}
			else
			{
				transform.localScale = new Vector3(-1f,1f,1);
			}

			if (transform.position == zebra.transform.position)
			{
				PlayerPrefs.SetInt("zebraArrested", 1);
				Destroy (zebra);
				dogFightDustScript.dogFightingStart();
			}
		}

		else if (rhino && rhinoScript.rhinoIsInside == true && gorillaScript.gorillaIsInside == false
		         && rhino.transform.position.x > dogLimitArea.transform.position.x && dogFightDustScript.dogIsFighting == false)
		{
			anim.SetBool("dogWalk", true);
			transform.position = Vector3.MoveTowards(transform.position, rhino.transform.position, dogSpeed * Time.deltaTime);
			dogWalked = true;

			if (transform.position.x >= rhino.transform.position.x)
			{
				transform.localScale = new Vector3(1f,1f,1);
			}
			else
			{
				transform.localScale = new Vector3(-1f,1f,1);
			}

			if (transform.position == rhino.transform.position)
			{
				if (highlightZebSafebox02)
				{
					Destroy(highlightZebSafebox02);
				}
				if (highlightZebSafebox)
				{
					Destroy(highlightZebSafebox);
				}
				PlayerPrefs.SetInt("rhinoArrested", 1);
				rhino.active = false;
				rhinoArrested = true;
				rhinoScript.rhinoIsInside = false;
				anim.SetBool("dogWalk", false);
				dogFightDustScript.dogFightingStart();
			}
		}
		else if((monkeyArrested && rhinoArrested) || (monkeyArrested && !rhino))
		{
			Destroy(zebra);
		}

		else
		{
			anim.SetBool("dogWalk", false);
		}

	}
}












