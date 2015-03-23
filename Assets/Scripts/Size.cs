using UnityEngine;
using System.Collections;

public class Size : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0)) {
			transform.localScale += new Vector3 (0.01f, 0.01f, 0.01f);
		}
		if (Input.GetKey (KeyCode.Mouse1)) {
			transform.localScale -= new Vector3 (0.01f, 0.01f, 0.01f);
		}
		if (Input.GetKey (KeyCode.Mouse2)) {
			transform.localScale = new Vector3 (10f, 10f, 10f);
		}
	}
}