﻿using UnityEngine;
using System.Collections;

public class CastleGoal : MonoBehaviour {
	public GameObject GameControllerReference;

	void OnTriggerEnter(Collider other){
		GameObject collidingObject = other.gameObject;
		if (collidingObject.tag == "minion") {
			Destroy (other.gameObject);
			GameControllerReference.GetComponent<GameController>().castleLife--;
			Debug.Log(GameControllerReference.GetComponent<GameController>().castleLife);
		}
		if (GameControllerReference.GetComponent<GameController> ().castleLife == 0) {
			PlayerPrefs.SetInt("HighScore", GameController.highScore);
			GameControllerReference.GetComponent<GameController>().score=0;
			Application.LoadLevel(1);
		}
	}
}
