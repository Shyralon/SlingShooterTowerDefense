using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {
	public Text scoreTextField;
	public Text highScoreTextField;

	void Start(){
		highScoreTextField.text = "Highscore: " + PlayerPrefs.GetInt("HighScore");
	}

	public void ChangeToScene (int scene) {
		Application.LoadLevel (scene);
	}
}
