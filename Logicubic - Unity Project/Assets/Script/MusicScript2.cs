using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicScript2 : MonoBehaviour {
	private static MusicScript2 instance = null;
	public string sceneToStopPlay;
	AudioSource audioData;
	Scene sceneCurrent;

	public static MusicScript2 Instance{
		get{
			return instance;
		}
	}

	void Awake(){
		if (instance != null && instance != this) {
        Destroy(this.gameObject);
        return;
    } else {
        instance = this;
    }
    DontDestroyOnLoad(this.gameObject);
	}

	// Use this for initialization
	void Start () {
		audioData = GetComponent<AudioSource>();
	}

	
	// Update is called once per frame
	void Update () {
		sceneCurrent = SceneManager.GetActiveScene();
		if (sceneCurrent.name == sceneToStopPlay){
			Debug.Log("Stop at " +sceneCurrent.name);
			audioData.Stop();
			//Destroy(this.gameObject);
		}
	}

}
