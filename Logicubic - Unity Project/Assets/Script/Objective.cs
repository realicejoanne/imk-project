using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Objective : MonoBehaviour {

	AudioSource audioData;

	// Use this for initialization
	void Start () {
		audioData = GetComponent<AudioSource>();	
	}

	void OnCollisionEnter (Collision collisionInfo){
		if (collisionInfo.collider.tag == "Player"){
			audioData.Play(0);
			Debug.Log("Started Playing");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
