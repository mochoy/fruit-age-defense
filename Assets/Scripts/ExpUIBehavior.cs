using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpUIBehavior : MonoBehaviour {
	private int lastExp;
	Text expText;

	// Use this for initialization
	void Start () {
		expText = this.gameObject.GetComponent<Text>();
		expText.text = "Exp: " + GlobalVariables.exp;
	}
	
	// Update is called once per frame
	void Update () {
		// Checks if the exp has changed from last time since checking
		if (lastExp != GlobalVariables.exp) {
			lastExp = GlobalVariables.exp;
			expText.text = "Exp: " + GlobalVariables.exp;
		}
	}
}
