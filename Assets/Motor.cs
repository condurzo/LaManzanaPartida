using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Motor : MonoBehaviour {
	// Use this for initialization
	public GameObject personaje1;
	public GameObject personaje2;
	public Text	TextName;
	public Text TextPM;

	public int sw;
	public int jugador;
	public int[][] tablero;
	public int PA;
	public int PM;
	public int valor;
	public int ptrcol;
	public int ptrrow;
	public int calculo;

	void Start () {
		ptrcol = 4;
		ptrrow = 4;
		PA = 5;
		PM = 4;
		valor = 0;

		tablero [1] [1] = 2;
		tablero [1] [2] = 0;
		tablero [1] [3] = 0;
		tablero [1] [4] = 0;

		tablero [2] [1] = 0;
		tablero [2] [2] = 0;
		tablero [2] [3] = 0;
		tablero [2] [4] = 0;

		tablero [3] [1] = 0;
		tablero [3] [2] = 0;
		tablero [3] [3] = 0;
		tablero [3] [4] = 0;

		tablero [4] [1] = 0;
		tablero [4] [2] = 0;
		tablero [4] [3] = 0;
		tablero [4] [4] = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (sw == 1){
			calculo = PM - valor;
			TextPM.text = calculo.ToString ();
			if (jugador == 1) {
				if (Input.GetKeyDown (KeyCode.LeftArrow)) {
					Debug.Log ("izq");
					personaje1.transform.position += new Vector3 (-1.55f, 0, 0);
					valor++;

				}
				if (Input.GetKeyDown (KeyCode.RightArrow)) {
					Debug.Log ("der");
					personaje1.transform.position += new Vector3 (1.55f, 0, 0);
					valor++;
				}

				if (Input.GetKeyDown (KeyCode.UpArrow)) {
					Debug.Log ("Up");
					personaje1.transform.position += new Vector3 (0, 0, 1.55f);
					valor++;
				}
				if (Input.GetKeyDown (KeyCode.DownArrow)) {
					Debug.Log ("Dowm");
					personaje1.transform.position += new Vector3 (0, 0, -1.55f);
					valor++;

				}
			}
			if (jugador == 2) {
				if (Input.GetKeyDown (KeyCode.LeftArrow)) {
					Debug.Log ("izq");
					personaje2.transform.position += new Vector3 (-1.65f, 0, 0);
					valor++;

				}
				if (Input.GetKeyDown (KeyCode.RightArrow)) {
					Debug.Log ("der");
					personaje2.transform.position += new Vector3 (1.65f, 0, 0);
					valor++;

				}

				if (Input.GetKeyDown (KeyCode.UpArrow)) {
					Debug.Log ("Up");
					personaje2.transform.position += new Vector3 (0, 0, 1.65f);
					valor++;
				}
				if (Input.GetKeyDown (KeyCode.DownArrow)) {
					Debug.Log ("Dowm");
					personaje2.transform.position += new Vector3 (0, 0, -1.65f);
					valor++;

				}
			}

			if (valor == PM) {
				valor = 0;
				if (jugador == 1) {
					jugador = 2;
					TextName.text = "Arquero";
				} else {
					jugador = 1;
					TextName.text = "Minero";
				}

			}

			if (Input.GetKeyDown (KeyCode.Return)) {
				Debug.Log ("Enter");
				valor = 0;
				if (jugador == 1) {
					jugador = 2;
					TextName.text = "Arquero";
				} else {
					jugador = 1;
					TextName.text = "Minero";
				}

			}

		}
	}
	public void ActivaTeclas(){
		sw = 1;
		jugador = 1;
		TextName.text = "Minero";
		TextPM.text = PM.ToString ();
	}
}
