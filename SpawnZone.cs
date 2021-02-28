using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    //VARIABLES//
    //Estamos haciendo referencia al script del player
    private PlayerController PlayerController;
    //Estamos haciendo referencia al script de la camara
    private CamaraFollow CamaraFollow;



    // Start is called before the first frame update
    void Start()
    {
        PlayerController = FindObjectOfType<PlayerController>();
        CamaraFollow = FindObjectOfType<CamaraFollow>();

        PlayerController.transform.position = this.transform.position;
        CamaraFollow.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, CamaraFollow.transform.position.z);    

    }


}
