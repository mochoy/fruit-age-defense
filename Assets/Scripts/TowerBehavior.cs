using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour {

	// For mouse clicking
	private Ray ray;
	private RaycastHit hit;
	// To change status of upgrade options
	private bool toActivate = false;
	private bool toDeactivate = false;
	// Gets upgrade options
	public GameObject optionOne;
	public GameObject optionTwo;

	// Update is called once per frame
	void Update () {
		// Gets whether left or right mouse is clicked
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		bool mouseClicked = Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1);

		// Mouse not on tower by default
		bool mouseOnTower = false;
		if (Physics.Raycast (ray, out hit) && hit.collider.tag == "Tower") {
			mouseOnTower = true;
		}

		// If clicked and mouse is over the tower, the current tower is selected
		if (mouseClicked && mouseOnTower) {
			toActivate = true;
		} else if (mouseClicked) {
			toDeactivate = true;
		}

		// If selected, show its upgrade options
		if (toActivate) {
			optionOne.SetActive (true);
			optionTwo.SetActive (true);
			toActivate = false;
		}

		// IF clicked elsewhere, hide its upgrade options again
		if (toDeactivate) {
			optionOne.SetActive (false);
			optionTwo.SetActive (false);
			toDeactivate = false;
		}

	}
}
