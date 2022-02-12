using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	//Permite colocar nuestras prefabs en la instancia
	public GameObject[] myPrefabs;

	//Variables para tiempo de spawn de las plataformas e ítems
	public float minTime = 1f;
	public float maxTime = 2f;

	void Start () {
		//Llamar al método Spawn
		Spawn();
		
	}

	//Método para el spawn de las plataformas y los ítems
	void Spawn () {
		Instantiate (myPrefabs [Random.Range(0,myPrefabs.Length)], transform.position, Quaternion.identity);
		Invoke("Spawn", Random.Range(minTime,maxTime));
		
	}
}
