using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyBehavior : MonoBehaviour {

	private GameObject [] waypoints;
	private int currentWaypoint;
	private GameObject nextWaypoint;
	public float speed;

	// Use this for initialization
	void Start () {
		currentWaypoint = 0;
		waypoints = GameObject.FindGameObjectsWithTag ("Waypoint").OrderBy( go => go.name ).ToArray();
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
		transform.position = Vector3.MoveTowards(transform.position, nextWaypoint.transform.position, speed*Time.deltaTime);
		if (transform.position == nextWaypoint.transform.position) {
			nextWaypoint = waypoints [++currentWaypoint];
		}
	}



}	//class
