using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManager : MonoBehaviour {

//Método que nos permite averiguar si un objeto colisionó con nuestro objeto
	void OnTriggerEnter2D(Collider2D other){

		//Comprobar si ha sido nuestro jugador el que colisionó con la deadzone
		if(other.tag == "Player"){
			//Si el jugador pierde resetea la partida
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
