using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MinionSpawner : MonoBehaviour {

	//inspector fields
	public GameObject MinionPrefab;
	public float minionCooldown;

	//internal fields
	private GameObject spawnpoint;
	private Vector3 spawnposition;

	// Use this for initialization
	void Awake (){
		Transform spawnPointTrans = transform.Find("spawnpoint");
		spawnpoint = spawnPointTrans.gameObject;
		spawnposition = spawnpoint.transform.position;
	}

	void Start () {
		InvokeRepeating ("spawnMinion", 0, minionCooldown);
	}

	void spawnMinion(){
		GameObject tmpObject = Instantiate (MinionPrefab) as GameObject;
		tmpObject.transform.position = spawnposition;
}
}