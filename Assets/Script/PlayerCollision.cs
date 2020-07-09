using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Transform player;
    public PlayerMovement playerMovement;

    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle"){
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
