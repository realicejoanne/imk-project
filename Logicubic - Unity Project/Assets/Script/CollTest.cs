using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision collisionInfo) {
		Debug.Log("COLLIDE");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
