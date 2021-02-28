using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    //VARIABLES
    //SEGUIMIENTO DE LA CAMARA AL PLAYER
    //Estamos haciendo referencia al player
    [SerializeField]
    private GameObject followTarget;
    [SerializeField]
    private Vector3 targetPosition;
    [SerializeField]
    private float camaraSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y + 3, this.transform.position.z);
    
        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, camaraSpeed *Time.deltaTime);
    }
}
