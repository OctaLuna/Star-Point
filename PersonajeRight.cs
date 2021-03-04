using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeRight : MonoBehaviour
{
    //VARIABLES//
    //Movimiento de el GameObject
    //Estamos referenciando el RigidBody de el GameObject
    Rigidbody2D Rigidbody2;
    //Estamos referenciando el SpriteRenderer de el GameObject
    SpriteRenderer spriteRenderer;
    //Esta es la velocidad de el GameObject
    public float Speed = 5f;
    //
    public float Delay = 40f;
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
