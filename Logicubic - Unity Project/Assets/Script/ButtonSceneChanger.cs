using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonSceneChanger : MonoBehaviour {

	int isCompleteTutorial;

	// Use this for initialization
	public void SceneChange (string sceneName){
		SceneManager.LoadScene(sceneName);
	}

	public void StartGameScene (){
		// is the player have completed the tutorial?
		isCompleteTutorial = PlayerPrefs.GetInt("isCompleteTutorial", 0);
		Debug.Log(isCompleteTutorial);

		// if not yet, go to tutorial
		if(isCompleteTutorial == 0)
			SceneManager.LoadScene("Level 0");
		// if yes, go to level picker
		else
			SceneManager.LoadScene("Level Picker");
	}
}
