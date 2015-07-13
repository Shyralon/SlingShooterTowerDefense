using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public int TimeRemaining;

	void Awake(){
		InvokeRepeating ("decreaseTime", 0, 1);
	}

	// Update is called once per frame
	void Update (){
		Debug.Log (TimeRemaining);
	if (TimeRemaining ==0){
			Debug.Log ("time is zero");
			Application.LoadLevel(0);
		}
	}

	void decreaseTime(){
		TimeRemaining--;
	}
}
