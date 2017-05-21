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
		middleAge[0].pushBack("Catapult", 100, 10, 2, 5, 50, 1, 2);
		middleAge[1].pushBack("Crossbow", 100, 5, 2, 5, 50, 1, 2);
		middleAge[2].pushBack("Bows", 100, 15, 2, 5, 50, 1, 2);
		modernAge[0].pushBack("Machine Gun", 100, 10, 2, 5, 50, 1, 2);
		modernAge[1].pushBack("Tank", 100, 10, 2, 5, 50, 1, 2);
		modernAge[2].pushBack("Sniper", 100, 10, 2, 5, 50, 1, 2);
		futureAge[0].pushBack("Laser Shooter", 100, 10, 2, 5, 50, 1, 2);
		futureAge[1].pushBack("Missile", 100, 10, 2, 5, 50, 1, 2);
		futureAge[2].pushBack("Bomb Launcher", 100, 10, 2, 5, 50, 1, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
