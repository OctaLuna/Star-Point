using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Esto es un controlador si en las transciones de escenas hay 2 camaras
        //Esto sucedera cuando no haya 2 player
        if(!PlayerController.playerCreated){
            //Esto es para que en la transcion no se elimine el camara de que hace la transcicion
            DontDestroyOnLoad(this.transform.gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }


}
