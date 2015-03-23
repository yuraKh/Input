using UnityEngine;
using System.Collections;

public class ADWS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.P) != true) {
			transform.position += new Vector3 ((Input.GetAxis ("Horizontal") / 2), (Input.GetAxis ("Vertical") / 2), 0);
		}
		if (Input.GetKey (KeyCode.RightAlt)) {
			transform.position += new Vector3((Input.GetAxis ("Horizontal")*0.5f), (Input.GetAxis ("Vertical")*0.5f), 0);
		}
		if (Input.GetKey (KeyCode.P)) {
			transform.position += new Vector3((Input.GetAxis ("Horizontal")/10), (Input.GetAxis ("Vertical")/10), 0);
		}
	}
}
