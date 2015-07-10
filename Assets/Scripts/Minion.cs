using UnityEngine;
using System.Collections;

public class Minion : MonoBehaviour {
	private float moveSpeed = -8;

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
		}

	}
}
