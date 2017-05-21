using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPositionHandler : MonoBehaviour {
	// For mouse clicking
	private Ray ray;
	private RaycastHit hit;
	// To change status of upgrade options
	private bool toActivate = false;
	private bool toDeactivate = false;
	// Gets the three circles for options
	public GameObject circleOption1;
	public GameObject circleOption2;
	public GameObject circleOption3;

	// Use this for initialization
	void Start () {
		// Set the positions for where the options would go
	}
	 
	// Update is called once per frame
	void Update () {
		// Gets whether left or right mouse is clicked
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		bool mouseClicked = Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1);

		// Mouse not on tower by default
		bool mouseOnObject = false;
		if (Physics.Raycast (ray, out hit) && hit.collider.tag == "TowerPosition") {
			mouseOnObject = true;
		}

		// Mouse not on tower by default
		bool mouseOnTower = false;
		if (Physics.Raycast (ray, out hit) && hit.collider.tag == "Tower") {
			mouseOnTower = true;
		}

		int numTowers = 3;
		// If there is a difference in the "era" or "age" load different picture for the options
		// Print out a button for each tower in this age

		// If selected, show the options for towers
		if (toActivate) {
			circleOption1.SetActive(true);
			circleOption2.SetActive(true);
			circleOption3.SetActive(true);
			toActivate = false;
		}

		// IF clicked elsewhere, hide options for towers
		if (toDeactivate) {
			circleOption1.SetActive(false);
			circleOption2.SetActive(false);
			circleOption3.SetActive(false);
			toDeactivate = false;
		}
	}
}
