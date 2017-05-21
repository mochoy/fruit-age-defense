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
		GlobalVariables.JSONData = File.ReadAllText (Application.dataPath + "/Resources/towerData.json");
		TowerData data = JsonUtility.FromJson<TowerData> (GlobalVariables.JSONData);
		var JSONresult = Json.Deserialize(result.Text) as Dictionary<string, object>;


	}
}

[Serializable]
public class TowerData {
	public object[] data;
}
