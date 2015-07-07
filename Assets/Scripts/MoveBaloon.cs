using UnityEngine;
using System.Collections;

public class MoveBaloon : MonoBehaviour {
	//public stuff
	public float speed= 0.2f;
	public int random=1;
	public int randomchange=20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveBaloon ();
	
	}

	void moveBaloon(){
		if (transform.position.y > 5){
				speed=speed*-1;
			}else if (transform.position.y < -3){
				speed=speed*-1;
			}
		random= Random.Range(1, randomchange);
		if (random ==3){
			speed=speed*-1;
		}
		transform.Translate (0,speed,0);
	}
}
