using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUIBehavior : MonoBehaviour {
	private int lastGold;
	Text goldText;

	// Use this for initialization
	void Start () {
		goldText = this.gameObject.GetComponent<Text>();
		goldText.text = "Gold: " + GlobalVariables.gold;
	}
	
	// Update is called once per frame
	void Update () {
		// Checks if the gold has changed from last time since checking
		if (lastGold != GlobalVariables.gold) {
			lastGold = GlobalVariables.gold;
			goldText.text = "Gold: " + GlobalVariables.gold;
		}
	}
}
