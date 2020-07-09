
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardSpeed = 500f;
    public float moveSpeed = 1000f;
    public Transform player;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardSpeed * Time.deltaTime);
        if(Input.GetKey("s")){
            rb.AddForce(0, 0, -moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        } else if (Input.GetKey("a")) {
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("d")) {
            rb.AddForce(moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(player.position.y < -0.1f){
            FindObjectOfType<GameManager>().endGame();
        }
    }
}