using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    
    public Playermovement move;

    void OnCollisionEnter ( Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
        }
    }
}
