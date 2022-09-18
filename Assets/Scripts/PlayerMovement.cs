using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //MOVE
    public CharacterController controller;
    public float defaultSpeed = 12f;
    public float speed;
    public float sprintSpeed = 24f;

    //GRAVITY
    public float gravity = -9.81f;
    private Vector3 velocity;

    //JUMP
    public float jumpHeight = 15f;

    //GROUND CHECKING
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool isGrounded;

    //COLLISION
    public float pushPower = 10000.0f;

    void Start()
    {
        speed = defaultSpeed;
        
    }
    

    void FixedUpdate()
    {

        MovePlayer();
        AddGravity();
        Jump();


        if (Input.GetKeyDown(KeyCode.Y))
        {
            Instantiate(GameObject.Find("WallSpawner"), Vector3.zero, GameObject.Find("WallSpawner").transform.rotation);
        }
    


    }

    private void MovePlayer()
    {
         //Get Input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Create movement vector
        Vector3 move =  transform.right * x + transform.forward * z;

        //Move Player
        controller.Move(move * speed * Time.deltaTime);

        // Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        } else
        {
            speed = defaultSpeed;
        } 
    }

    private void AddGravity()
    {
        //Ground checking
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) velocity.y = -2f;

        // Add gravity to player
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime); 
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }


    private void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic) return;

        if(hit.gameObject.layer.Equals("Ground") || body == null || body.isKinematic) return;


        body.velocity = hit.moveDirection * pushPower;

    }
}
