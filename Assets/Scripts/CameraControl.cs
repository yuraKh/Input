using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse0)){
			transform.position += new Vector3 (Input.GetAxis("MouseX"), Input.GetAxis ("MouseY"), 0);
		}

			transform.position += new Vector3 (0, 0, Input.GetAxis ("Mouse ScrollWheel"));
	}
}
