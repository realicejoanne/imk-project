using UnityEngine;
using System.Collections;

public class GravityManager : MonoBehaviour {

    public string gravityStatus;
    public CameraTest cameraTest;

    void Start(){
        cameraTest = GameObject.FindObjectOfType<CameraTest>();

        gravityStatus = "down";
    }

    void OnCollisionEnter(Collision collisionInfo) {
        
        // Check what that object collides with 
        // Debug.Log(collisionInfo.collider.name);

        // Gravity to the LEFT of za warudo
        if (collisionInfo.collider.tag == "plane_left") {
            gravityStatus = "left";

            Physics.gravity = new Vector3(0, 0, 9.81f);
            cameraTest.updateGravityAtCamera(gravityStatus);
        }
        // Gravity to the RIGHT of za warudo
        if (collisionInfo.collider.tag == "plane_right") {
            gravityStatus = "right";

            Physics.gravity = new Vector3(0, 0, -9.81f);
        }
        // Gravity to UPSIDE-DOWN of the world
        if (collisionInfo.collider.tag == "plane_up") {
            gravityStatus = "up";

            Physics.gravity = new Vector3(0, 9.81f, 0);
        }
        // Gravity to DOWN of the world
        if (collisionInfo.collider.tag == "plane_down") {
            gravityStatus = "down";

            Physics.gravity = new Vector3(0, -9.81f, 0);
        }
        // Gravity to FRONT of the world
        if (collisionInfo.collider.tag == "plane_front") {
            gravityStatus = "front";

            Physics.gravity = new Vector3(9.81f, 0, 0);
        }
        // Gravity to REAR of the world
        if (collisionInfo.collider.tag == "plane_rear") {
            gravityStatus = "rear";

            Physics.gravity = new Vector3(-9.81f, 0, 0);
        }


        /* BENDED PLANE -- test */
        // Gravity on a bended plane
        if (collisionInfo.collider.tag == "plane_bended") {
            //Debug.Log("Down!");
            gravityStatus = "bended";
            float y, z;

            for (float i = 0; i < 100; i = i + Time.deltaTime){
                y = -i * 0.0981f;
                z = i * 0.0981f;
                Physics.gravity = new Vector3(0.0f, -9.81f - y, 0.0f + z);
            }
            Debug.Log("Finished!");
        }
    }

    public string getGravityStatus(){
        return this.gravityStatus;
    }
}
