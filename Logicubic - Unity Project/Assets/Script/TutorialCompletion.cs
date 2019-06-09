using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCompletion : MonoBehaviour {

	void OnCollisionEnter (Collision collisionInfo){
		if (collisionInfo.collider.tag == "Player"){
			PlayerPrefs.SetInt("isCompleteTutorial", 1);
			Debug.Log(PlayerPrefs.GetInt("isCompleteTutorial", 0));
		}
	}
}
