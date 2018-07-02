using UnityEngine;
using System.Collections;

public class regionSelection : MonoBehaviour
{
	float speed = 2.5f;
	private float posX;
	private float posY;
	private float posZ;
	
	float lastPosY;
	
	GameObject cameraPosYmax;
	GameObject cameraPosYmin;

	void Start () 
	{

		cameraPosYmax = GameObject.Find ("cameraPosYmax");
		cameraPosYmin = GameObject.Find ("cameraPosYmin");

		posX = transform.position.x;
		posY = transform.position.y;
		posZ = transform.position.z;

	}

	void Update()
	{		
		posY = transform.position.y;

		if (Input.touchCount == 1) 
		{
			if ((posY > cameraPosYmin.transform.position.y) && (posY <  cameraPosYmax.transform.position.y))				
			{
				lastPosY = transform.position.y;

				// note that in landscape y is actually x in mobile phone 
				Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
				//posX does not work
				//transform.Translate(posX, -touchDeltaPosition.y * speed * Time.deltaTime, posZ);
				transform.Translate(0, -touchDeltaPosition.y * speed * Time.deltaTime, posZ);
			}

			else
			{
				transform.position = new Vector3(0, lastPosY, posZ);			
			}
		}
	}

}
	






	

	