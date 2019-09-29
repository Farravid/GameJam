using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public static bool tengoLlave;
    public static bool tengoPocion;
	//poner todos los recolectables

	public GameObject llave;
	public GameObject pocion;

	private void Start(){
        tengoLlave = false;
        tengoPocion = false;
		llave.SetActive(false);
		pocion.SetActive(false);
	}

	private void Update(){
		if(tengoLlave == true){
			llave.SetActive(true);
		}
	}

}
