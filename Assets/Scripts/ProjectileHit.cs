using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour {
	
public GameObject explosion;

void OnCollisionEnter(Collision collision){
		Instantiate (explosion, this.transform.position, Quaternion.Euler (collision.contacts[0].normal+new Vector3(-90,0,0)));
		Destroy (gameObject);
	}


}
