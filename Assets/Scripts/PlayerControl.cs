using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	//Fuerza del salto
	public float jumpForce = 20f;

	//Velocidad horizontal
	public float velocity = 5f;

	//Variables que nos permiten acceder a los componentes de Player
	private Rigidbody2D _myRigidBody2D;

	void Start () {

		//Acceder al RigidBody2D
		_myRigidBody2D = GetComponent<Rigidbody2D>();
		
	}
	

	void Update () {

		//Detectar cuando el jugador presione el botón saltar
		if(Input.GetKeyDown(KeyCode.Space)){

			//Llamar al método encargado del salto
			Jump();
		}

		//LLamar al método para que corra desde que el programa dé inicio (corre indefinidamente)
		Run ();
		
	}

	//Método para la mecánica del salto
	void Jump(){
		//Aplicamos una fuerza de salto en el componente Y(Hacia arriba) del Vector2
		_myRigidBody2D.velocity = new Vector2 (_myRigidBody2D.velocity.x, jumpForce);
	}

	//Método para corren en horizontal
	void Run(){
		_myRigidBody2D.velocity = new Vector2 (velocity, _myRigidBody2D.velocity.y);
	}
}
