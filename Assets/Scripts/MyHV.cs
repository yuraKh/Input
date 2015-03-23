using UnityEngine;
using System.Collections;

public class MyHV : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Input.GetAxis ("MyH"), Input.GetAxis ("MyV"), 0);	
	}
}
