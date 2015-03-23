using UnityEngine;
using System.Collections;

public class ControlSprite : MonoBehaviour {

	string s;
	public GameObject [] Table = new GameObject[14];
	//GameObject Appear;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

		if (Input.anyKey) {
			s += Input.inputString;
			//print (s);
		
			for (int i = 0; i < Table.Length; i++) {	

				if (s == Table [i].name) {
			
					Instantiate( Table [i], new Vector3 (Random.Range(-29f, 29f), Random.Range(-8f, 8f), 0), new Quaternion (0,0,0,0));			

					s ="";
				}
			}
		}
	}
}
