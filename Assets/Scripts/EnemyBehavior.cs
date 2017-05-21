using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour {

	private GameObject [] waypoints;
	private int currentWaypoint = 0;
	private GameObject nextWaypoint;

	public float speed = 10;

//	private Text healthText;

	// Use this for initialization
	void Start () {
		waypoints = GameObject.FindGameObjectsWithTag ("Waypoint").OrderBy( go => go.name ).ToArray();	//get all waypoints, and make sure they're in order
		transform.position = waypoints [currentWaypoint].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentWaypoint < waypoints.Length) {
			if (nextWaypoint == null) {
				nextWaypoint = waypoints[currentWaypoint];
			}
			moveToNextWaypoint ();
		}
	}

	void moveToNextWaypoint () {
		transform.position = Vector3.MoveTowards(transform.position, nextWaypoint.transform.position, speed*Time.deltaTime);	//move enemy towards wayponts
		if (transform.position == nextWaypoint.transform.position) {
			//if waypoint reached, move to next waypoint
			if (currentWaypoint < waypoints.Length-1) {
				nextWaypoint = waypoints [++currentWaypoint];

			//if on last waypoint, decrement health and kill enemy
			} else {	
				GlobalVariables.health--;
//				healthText.text = "Heath: " + GlobalVariables.health.ToString ();
//				Debug.Log(health);
				Destroy (this.gameObject);
			}
		}
			
	}



}	//class
