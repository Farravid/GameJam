using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerDungeon : MonoBehaviour
{
    private Transform target;
    private float smoothSpeed = 5f;
    [SerializeField] private float minX, minY, maxX, maxY;


    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
   
    
    void LateUpdate()
    {
       //Hacer que la camara haga tracking al personaje.
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, -10) ,smoothSpeed * Time.deltaTime) ;
        //Limitamos el rango de la camara a los bordes.
        transform.position = new Vector3(Mathf.Clamp(transform.position.x , minX , maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);


    }
}
