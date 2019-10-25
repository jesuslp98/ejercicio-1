using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Este es un ejemplo de texto enriquecido con <b> negrita. </b>");

		Debug.Log ("Este es un ejemplo de texto con <i> <b> negrita y cursiva. </b> </i>");

		Debug.Log ("Este es un ejemplo de texto con <color=red> <i>cursiva y en rojo.</i> </color>");

		Debug.Log ("Este es un ejemplo de texto con <b>negrita y en <color=red>rojo</color> </b> ");

		Debug.Log ("Este es un ejemplo de texto con <color=green> <size=20>verde y a 20 pixeles.</size> </color>");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
