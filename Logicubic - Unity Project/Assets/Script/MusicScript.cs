using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicScript : MonoBehaviour {
	public string sceneToStopPlay;
	static bool isMustPlaying = false; 
	static bool reachesStop = false;
	AudioSource audioData;
	private Scene sceneCurrent;

	// Use this for initialization
	void Start () {
		audioData = GetComponent<AudioSource>();
	}

	
	// Update is called once per frame
	void Update () {
		sceneCurrent = SceneManager.GetActiveScene();

		if (!reachesStop){
			if (!isMustPlaying) {
				audioData.Play(0);
				Debug.Log("Play at " +sceneCurrent.name);
				DontDestroyOnLoad (gameObject);
				isMustPlaying = true;
			}
		}		
		
		if (!reachesStop){
			if (sceneCurrent.name == sceneToStopPlay){
				Debug.Log("Stop at " +sceneCurrent.name);
				audioData.Stop();
				reachesStop = true;
			}
		}
		
	}
}
