﻿using UnityEngine;
using System.Collections;

public class PostURL : MonoBehaviour {

	void Start () {
		string url = "localhost:8080";
		WWWForm form = new WWWForm();
		form.AddField("var1", "value1");
		form.AddField("var2", "value2");
		form.AddField ("var3", "value3");
		WWW www = new WWW(url, form);
		StartCoroutine(WaitForRequest(www));
	}
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
			// check for errors
			if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.data);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}    
	}    
}
