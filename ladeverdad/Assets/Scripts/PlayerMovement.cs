using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;            
    private Rigidbody2D rb2d;      
    public Vector2 moveVelocty;

    public float jumpForce = 1f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }
    void Update()
    {
        //movimiento
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        moveVelocty = movement.normalized * speed;

        //salto
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     rb2d.MovePosition(rb2d + )
        // }

	}

    void FixedUpdate(){

        //movimiento
        rb2d.MovePosition(rb2d.position + moveVelocty * Time.fixedDeltaTime);
    }
}
