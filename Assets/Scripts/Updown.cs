using UnityEngine;
using System.Collections;

public class Updown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q) != true) {
			transform.position += new Vector3 ((Input.GetAxis ("Horizontall") / 2), (Input.GetAxis ("Verticall") / 2), 0);
		}
		if (Input.GetKey (KeyCode.LeftAlt)) {
			transform.position += new Vector3((Input.GetAxis ("Horizontall")*0.5f), (Input.GetAxis ("Verticall")*0.5f), 0);
		}
		if (Input.GetKey (KeyCode.Q)) {
			transform.position += new Vector3((Input.GetAxis ("Horizontall")/10), (Input.GetAxis ("Verticall")/10), 0);
		}
	}
}
