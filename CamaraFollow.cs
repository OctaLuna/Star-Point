using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    //VARIABLES
    //SEGUIMIENTO DE LA CAMARA AL PLAYER
    //Estamos haciendo referencia al player
    [SerializeField]
    public GameObject followTarget;
    [SerializeField]
    public Vector3 targetPosition;
    [SerializeField]
    public float camaraSpeed = 4f;


    public static bool CamaraCreated;
    // Start is called before the first frame update
    void Start()
    {
        //Esto es un controlador si en las transciones de escenas hay 2 camaras
        //Esto sucedera cuando no haya 2 player
        if(!CamaraCreated){
            CamaraCreated = true;
            //Esto es para que en la transcion no se elimine el camara de que hace la transcicion
            DontDestroyOnLoad(this.transform.gameObject);
        }
        else{
            Destroy(gameObject);
        }
    } 
    

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y + 3, this.transform.position.z);
    
        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, camaraSpeed *Time.deltaTime);
    }
}
