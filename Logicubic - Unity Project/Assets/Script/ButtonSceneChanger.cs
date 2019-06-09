using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonSceneChanger : MonoBehaviour {

	// Use this for initialization
	public void SceneChange (string sceneName){
		SceneManager.LoadScene(sceneName);
	}

}
