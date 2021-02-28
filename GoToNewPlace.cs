using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Esto es para controlar las escenas del videojuego

public class GotoNewPlace : MonoBehaviour
{
    //VARIABLES//
    //Esto es el nombre de la escena a la cual tenemos que cambiar
    public string newPlaceName = "New Scene Name Here";
    
    
    
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag.Equals("Player")){
            SceneManager.LoadScene(newPlaceName);
        }
    }
}
