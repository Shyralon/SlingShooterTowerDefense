using UnityEngine;
using System.Collections;
using UnityEngine.UI;

enum GameState {
	idle,
	playing,
	levelEnd
}

public class GameController : MonoBehaviour {
	public static GameController S;

	// Public Inspector Fields
	public Text scoreText;
	public Text castleLifeText;
	public Text HighScoreText;
	public int castleLife;

	// Private internal fields
	public int score =0;
	public static int highScore;


	void Awake() {
		S = this;
	}

	void Update () {
		updateScore ();
		updateLive ();
		updateHighScore ();
	}

	void updateScore(){
		scoreText.text = "Score: " + score;
	}

	void updateLive(){
		castleLifeText.text = "Live: " + castleLife;
	}

	void updateHighScore(){
		HighScoreText.text = "Highscore: " + highScore;
		if (score > highScore) {
			highScore=score;
		}
	}

}
