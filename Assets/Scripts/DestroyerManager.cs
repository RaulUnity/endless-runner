using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerManager : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other){
		//Detectar si el objeto que colisiona no es el jugador
		if (other.tag != "Player") {
			//Destruye el objeto con el que colisiona
			Destroy (other.gameObject);
		}
	}
}
