using UnityEngine;
using System.Collections;

public class Minion : MonoBehaviour {
	private float moveSpeed = -8;
	private GameObject GamecontrollerReference;
	private int scoreValue = 10;

	void Awake(){
		Random.Range(moveSpeed+3,moveSpeed-3);
		GamecontrollerReference = GameObject.FindGameObjectWithTag ("GameController");

	}

	void Update(){
		moveMinion ();
	}

	void moveMinion(){
		transform.Translate (Time.deltaTime * moveSpeed,0,0);
	}

	void OnCollisionEnter(Collision collision){
		GameObject objectHit;
		objectHit = collision.gameObject;
		if (objectHit.tag == "Projectile") {
			Destroy (objectHit);
			Destroy (gameObject);
			GamecontrollerReference.GetComponent<GameController>().score = GamecontrollerReference.GetComponent<GameController>().score+scoreValue;

		}

	}
}
