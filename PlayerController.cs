using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES//
    //MOVIMIENTO 
    //Estamos referenciando a el RigidBody del Player
    Rigidbody2D Rigidbody;
    //Esta es la velocidad del player
    public float PlayerSpeed = 2f;

    //SALTO
    //Esta es la fuerza de salto
    public float JumpForce = 2f;
    //Esto es para declarar el suelo donde el Player pueda saltar
    bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        //Estamos declarando el RigidBody del player
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(isGrounded == true){
            Jump();
        }
    }

    //FUNCIONES//
    //Movimiento
    void Move(){
        //Esto es para podernos mover de en eje horizontal
        Rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * PlayerSpeed, Rigidbody.velocity.y);
    }
    //Salto
    void Jump(){
        if(Input.GetButtonDown("Jump")){
            //Esta es la formula para el salto del player
            Rigidbody.AddForce(Vector2.up * JumpForce);
            Debug.Log("JUMP");
            isGrounded = false;
        }    
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Ground")){
            isGrounded = true;
            Debug.Log("isGround");
        }
    }
}
