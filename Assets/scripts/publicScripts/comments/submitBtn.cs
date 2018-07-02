using UnityEngine;
using System.Collections;

using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class submitBtn : MonoBehaviour {

	comments commentsScript;

	// Use this for initialization
	void Start () 
	{
		commentsScript = GameObject.Find ("Main Camera").GetComponent<comments>();
	}
	
	void OnMouseDown()
	{
		string textToSend = commentsScript.commentsTexts;


		Debug.Log("Success, email sent through SMTP!");  

		commentsScript.commentsTexts = "Thank you so much for your comment(s)...";
	
	}
}
