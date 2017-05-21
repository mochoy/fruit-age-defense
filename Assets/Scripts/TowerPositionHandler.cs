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
	public List<GameObject> options;
	public List<List<string>> optionsForAges;


	// Use this for initialization
	void Start () {
		optionsForAges.Add (new List<string> { "Trebuchet", "Bows" });

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

		// TODO If there is a difference in the "era" or "age" load different picture for the options

		// If selected, show the options for towers
		if (toActivate) {
			for (int i = 0; i < 5; i++) {
				options [i].SetActive (true);
			}
			toActivate = false;
		}

		// IF clicked elsewhere, hide options for towers
		if (toDeactivate) {
			for (int i = 0; i < 5; i++) {
				options [i].SetActive (false);
			}
			toDeactivate = false;
		}
	}
}
