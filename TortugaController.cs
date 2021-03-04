using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TortugaController : MonoBehaviour
{
    //VARIABLES//
    //Movimiento de la tortuga
    //Estamos referenciando el RigidBody de la tortuga
    Rigidbody2D Rigidbody2;
    //Estamos referenciando el SpriteRenderer de la tortuga
    SpriteRenderer spriteRenderer;
    //Esta es la velocidad de la tortuga
    public float Speed = 1.5f;
    //
    public float Delay = 8.5f;
    float timeBeforeChange;
    private bool StartMovement = false;



    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2 = GetComponent<Rigidbody2D>(); 
        spriteRenderer = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(StartMovement == true){
            Rigidbody2.velocity = Vector2.left * Speed;
            if(timeBeforeChange < Time.time){
                Speed *= -1;
                timeBeforeChange = Time.time + Delay;
            }
            if(Speed > 0){
                spriteRenderer.flipX = true;
            }
            else if(Speed < 0){
                spriteRenderer.flipX = false;
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player"){
            Debug.Log("Tortuga");
             StartMovement = true;
        }
    }
}
