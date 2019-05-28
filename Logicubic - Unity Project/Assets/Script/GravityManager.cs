using UnityEngine;
using System.Collections;

public class GravityManager : MonoBehaviour {

    string gravityStatus;
    CapsuleCollider headCollider;

    void Start() {
        gravityStatus = "down";
    }

    void OnCollisionEnter(Collision collisionInfo) {

        foreach (ContactPoint contact in collisionInfo.contacts) {
            //Debug.Log(contact.thisCollider.name + " hit " + contact.otherCollider.name);

            // Only change gravity if cube is collision with the FACE
            if (contact.thisCollider.name == "Face Cube Player") {               
                // Check what that object collides with 
                // Debug.Log(collisionInfo.collider.name);

                // Gravity to the LEFT of za warudo
                if (collisionInfo.collider.tag == "plane_left") {
                    gravityStatus = "left";
                    Debug.Log("Gravity direction: Left");

                    Physics.gravity = new Vector3(0, 0, 9.81f);
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
            }
        }
        
        
    }
    
    public string getGravityStatus(){
        return this.gravityStatus;
    }
}
