using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChangeBehavior : MonoBehaviour {
	private int lastHealth;
	public GameObject gameOverText;
	Text healthText;

	// Use this for initialization
	void Start () {
		GlobalVariables.health = 10;
		healthText = this.gameObject.GetComponent<Text>();
		healthText.text = "Health: " + GlobalVariables.health;
	}
	
	// Update is called once per frame
	void Update () {
		//Checks if the health has changed from last time since checking
		if (lastHealth != GlobalVariables.health) {
			lastHealth = GlobalVariables.health;
			healthText.text = "Health: " + GlobalVariables.health;
			if (GlobalVariables.health == 0) {
				// If health is 0, then die
				gameOverText.SetActive(true);
			}
		}
		
	}
}
