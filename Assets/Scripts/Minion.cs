using UnityEngine;
using System.Collections;

public class Minion : MonoBehaviour {
	public float moveSpeed = -8;
	private GameObject GamecontrollerReference;
	private int scoreValue = 10;

	void Awake(){
	//	moveSpeed=Random.Range(moveSpeed+2,moveSpeed-2);
		GamecontrollerReference = GameObject.FindGameObjectWithTag ("GameController");

	}

	void Update(){
		moveMinion ();
	}

	void moveMinion(){
		transform.Translate (0,0,Time.deltaTime * moveSpeed*-1);
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
