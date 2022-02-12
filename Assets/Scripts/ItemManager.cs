using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	//Objeto de la clase ScoreManager
	ScoreManager scoreManager;

	void Start (){

		scoreManager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
	}


	void OnTriggerEnter2D(Collider2D other){
	
		//Detectar si es el jugador quien atraviesa el item
		if(other.tag == "Player"){
			scoreManager.UpdateScore ();
			Destroy (gameObject);
		}
	}
}
