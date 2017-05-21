using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerOptionsBehavior : MonoBehaviour {
	//For mouse clicking
	private Ray ray;
	private RaycastHit hit;
	public int Index;
	public string name;

	void Start() {
	}

	// Update is called once per frame
	void Update () {
		// Gets whether left or right mouse is clicked
		bool mouseClicked = Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1);

		// Mouse not on tower by default
		bool mouseOnTower = false;
		if (Physics.Raycast (ray, out hit) && hit.collider.tag == "Tower") {
			mouseOnTower = true;
		}

		// If selected, return the index
		if (mouseClicked && mouseOnTower) {
			
		}
	}

}
