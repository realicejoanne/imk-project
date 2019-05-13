using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGravityOrientation : MonoBehaviour {

	Rigidbody rigidbody;
	GravityManager gm;
	public string gravityOrientation = "down";

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
		gm = GameObject.FindObjectOfType<GravityManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (gravityOrientation == gm.getGravityStatus()){
			rigidbody.useGravity = true;
		}
		else
			rigidbody.useGravity = false;
	}
}
