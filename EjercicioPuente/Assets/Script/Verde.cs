using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verde : MonoBehaviour {
	public float velocidad = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			transform.Translate (Vector2.left * velocidad * Time.deltaTime);
			Debug.Log ("Hemos pulsado la tecla E");
		}
		if (Input.GetKey (KeyCode.F)) {
			transform.Translate (Vector2.right * velocidad * Time.deltaTime);
			Debug.Log ("Hemos pulsado la tecla F");
		}
		if (Input.GetKey (KeyCode.G)) {
			transform.Translate (Vector2.up * velocidad * Time.deltaTime);
			Debug.Log ("Hemos pulsado la tecla G");
		}
		if (Input.GetKey (KeyCode.H)) {
			transform.Translate (Vector2.down * velocidad * Time.deltaTime);
			Debug.Log ("Hemos pulsado la tecla H");
		}
	}
}
