using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//test2
		//test3
		transform.position += new Vector3 (Input.GetAxis("Horizontal"),0,0);			
	}
}
