using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2D : MonoBehaviour {

	//Almacena el "transform" u posición del objeto que la cámara seguirá
	public Transform targetPlayer;

	void Update () {

		//Instrucción para que la cámara siga al jugador
		transform.position = new Vector3 (targetPlayer.position.x + 6, 0, -10);
		
	}
}
