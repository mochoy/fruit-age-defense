using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerData : MonoBehaviour {
	public string name;
	public int range;
	public int rateOfFire;
	public int damage;
	public int areaOfEffect;
	public int cost;
	public int upgradePathOne;
	public int upgradePathTwo;

	public void pushBack(string nm, int rg, int rof, int dmg, int aoe, int ct, int u1, int u2) {
		name = nm;
		range = rg;
		rateOfFire = rof;
		damage = dmg;
		areaOfEffect = aoe;
		cost = ct;
		upgradePathOne = u1;
		upgradePathTwo = u2;
	}
}
