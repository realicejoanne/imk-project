using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicScript : MonoBehaviour {
	static bool isMustPlaying = false; 
	AudioSource audioData;
	Scene sceneCurrent;

	// Use this for initialization
	void Start () {
		audioData = GetComponent<AudioSource>();
	}

	
	// Update is called once per frame
	void Update () {
		if (!isMustPlaying) {
			audioData.Play(0);
			DontDestroyOnLoad (gameObject);
			isMustPlaying = true;
		}

		sceneCurrent = SceneManager.GetActiveScene();
		
		if (sceneCurrent.name == "Level 0" || sceneCurrent.name == "Level Picker"){
			audioData.Stop();
			isMustPlaying = false;
		}
	}
}
