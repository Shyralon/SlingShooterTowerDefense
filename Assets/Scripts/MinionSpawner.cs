using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MinionSpawner : MonoBehaviour {

	//inspector fields
	public GameObject MinionPrefab;
	public float movespeed;
	public Vector3 movevector;
	//public int spawnTime;
	public float minionCooldown;

	//internal fields
	private GameObject spawnpoint;
	private Vector3 spawnposition;
	private List<GameObject> minions =new List<GameObject>();
	private int MinionsOnScreen;
	private float timer;

	// Use this for initialization
	void Awake (){
		Transform spawnPointTrans = transform.Find("spawnpoint");
		spawnpoint = spawnPointTrans.gameObject;
		spawnposition = spawnpoint.transform.position;
	}

	void Start () {
		InvokeRepeating ("spawnMinion", 0, minionCooldown);
	}
	
	// Update is called once per frame
	void Update () {
		moveMinions ();
		/*timer += Time.deltaTime;
		if (timer >= minionCooldown) {
			moveMinions();
			timer=0;*/
	}

	void spawnMinion(){
		minions.Add(Instantiate (MinionPrefab) as GameObject);
		minions[minions.Count-1].transform.position = spawnposition;
		}

	void moveMinions(){
		for (int i=0; i<minions.Count; i++) {
			minions [i].transform.position = minions [i].transform.position + movevector;
		}
	}
}
