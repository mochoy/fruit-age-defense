using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		initJSONData ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//store entire JSON file data into global variable
	void initJSONData () {
		//store json string into global variable
		string path = Application.dataPath + "/Resources/data.json";
		GlobalVariables.JSONData = File.ReadAllText (path);
		Debug.Log (GlobalVariables.JSONData);
	}
}
