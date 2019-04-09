using UnityEngine;
using System.Collections;

public class GravityManager : MonoBehaviour {

    public string gravityStatus;

    void Start(){
        gravityStatus = "down";
    }

    void OnCollisionEnter(Collision collisionInfo) {
        
        // Check what that object collides with 
        // Debug.Log(collisionInfo.collider.name);

        // Gravity to the LEFT of za warudo
        if (collisionInfo.collider.tag == "plane_left") {
            //Debug.Log("To the LEFT!");
            gravityStatus = "left";

            Physics.gravity = new Vector3(0, 0, 9.81f);
        }

        // Gravity to the RIGHT of za warudo
        if (collisionInfo.collider.tag == "plane_right") {
            //Debug.Log("To the RIGHT");
            gravityStatus = "right";

            Physics.gravity = new Vector3(0, 0, -9.81f);
        }

        // Gravity to UPSIDE-DOWN of the world
        if (collisionInfo.collider.tag == "plane_up") {
            //Debug.Log("UPSIDE-DOWN!");
            gravityStatus = "up";

            Physics.gravity = new Vector3(0, -9.81f, 0);
        }
    }

    public string getGravityStatus(){
        return this.gravityStatus;
    }
}
