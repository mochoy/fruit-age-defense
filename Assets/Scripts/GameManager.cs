using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	//Stores game data
	public List<TowerData> middleAge;
	public List<TowerData> modernAge;
	public List<TowerData> futureAge;

	// Use this for initialization
	void Start () {
		middleAge.pushBack("Catapult", 100, 10, 2, 5, 50, 1, 2);
		middleAge.pushBack("Crossbow", 100, 5, 2, 5, 50, 1, 2);
		middleAge.pushBack("Bows", 100, 15, 2, 5, 50, 1, 2);
		modernAge.pushBack("Machine Gun", 100, 10, 2, 5, 50, 1, 2);
		modernAge.pushBack("Tank", 100, 10, 2, 5, 50, 1, 2);
		modernAge.pushBack("Sniper", 100, 10, 2, 5, 50, 1, 2);
		futureAge.pushBack("Laser Shooter", 100, 10, 2, 5, 50, 1, 2);
		futureAge.pushBack("Missile", 100, 10, 2, 5, 50, 1, 2);
		futureAge.pushBack("Bomb Launcher", 100, 10, 2, 5, 50, 1, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
