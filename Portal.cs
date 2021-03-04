using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Esto es para manejar las escenas en el juego

public class Portal : MonoBehaviour
{
    //VARIABLES//
    //Portal
    bool transcition = false;
    public string newPlaceName = "Pon el nombre de la escena a la que quieres ir";


    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Player")){
            SceneManager.LoadScene(newPlaceName);
        }
    }
}
