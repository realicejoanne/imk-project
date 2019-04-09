using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

    public float moveSpeed;
    private GravityManager gm;
    public string gravityDirection;

	// Use this for initialization
	void Start () {
        //GameObject gravityManager = new GameObject("GravityManager");

        gm = GameObject.FindObjectOfType<GravityManager>();
        
        gravityDirection = "down";

        moveSpeed = 7f;
        print("Yo im a cube. Called from the start");
	}
	
	// Update is called once per frame
	void Update () {        
        /* Manage to move under certain gravity */ 
        if (gravityDirection != gm.getGravityStatus()){
            gravityDirection = gm.getGravityStatus();
            //changeBoxFace(gravityDirection);
            Debug.Log("Gravity direction: " +gravityDirection);
        }

        /* If under normal gravity -- "down" */
        if (gravityDirection == "down"){
            transform.Rotate(0.0f, 2.0f * Input.GetAxis("Mouse X"), 0.0f);
            transform.Translate(
                moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 
                0.0f, 
                moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        }
        /* If under normal gravity -- "left" */
        if (gravityDirection == "left"){
            transform.Rotate(0.0f, 2.0f * Input.GetAxis("Mouse Y"), 0.0f);
            transform.Translate(
                moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime,
                moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 
                0.0f);
        }

        // Check gravity status -- gm.getGravityStatus();
	}

    void changeBoxFace (string direction){
        if (direction == "left"){
            transform.Rotate(-90.0f, 0.0f, 0.0f);
        }
    }
}
