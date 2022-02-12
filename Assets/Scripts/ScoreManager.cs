using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {


	//Variable que almacena la puntuación
	public int score = 0;

	//Variable que almacena la puntuación en el texto en pantalla
	public Text scoreText;

	public void UpdateScore (){
	
		score++;
		scoreText.text = "SCORE = " + score.ToString ();
	}
}
