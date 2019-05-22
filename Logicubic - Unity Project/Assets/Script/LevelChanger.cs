using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChanger : MonoBehaviour {

	public string targetLevel;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter (Collision collisionInfo){
		if (collisionInfo.collider.tag == "Player"){
			SceneManager.LoadScene(targetLevel);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
