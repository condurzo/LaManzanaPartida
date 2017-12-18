using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Esto es una prueba
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
			Debug.Log("Finalizar");
		
	}
}
