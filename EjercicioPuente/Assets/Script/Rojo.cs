using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo : MonoBehaviour {
	public float velocidad = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector2.left * velocidad * Time.deltaTime);
			Debug.Log ("Hemos pulsado la tecla A");
		}
		if (Input.GetKey (KeyCode.B)) {
			transform.Translate (Vector2.right * velocidad * Time.deltaTime);
			Debug.Log ("Hemos pulsado la tecla B");
		}
	}
}
