using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

	public float speedH = 2.0f;
	public float speedV = 2.0f;
	private float yaw = 0.0f;
	private float pitch = 0.0f;

	public Camera cam;
	private string gravityDirection;

	// Use this for initialization
	void Start () {
		gravityDirection = "down";
	}
	
	// Update is called once per frame
	void Update () {
		
		yaw = speedH * Input.GetAxis("Mouse X");
		pitch = speedV * Input.GetAxis("Mouse Y");

		//transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
		if (gravityDirection == "down"){
			Vector3 rotasi = new Vector3(-pitch, 0f, 0f);
			cam.transform.Rotate(rotasi);
		}
		else {//if (gravityDirection == "left"){
			Vector3 rotasi = new Vector3(-pitch, 0f, 0f);
			cam.transform.Rotate(rotasi);
		}
	}

	public void rotateLeftCamera(){
		cam.transform.Rotate(-90.0f, 0f,0f);
	}

	public void updateGravityAtCamera(string direction){
		this.gravityDirection = direction;
	}
}
