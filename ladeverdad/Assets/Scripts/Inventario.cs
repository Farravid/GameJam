using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
	public static bool tengoLlave = false;
	public static bool tengoPocion = false;
	//poner todos los recolectables

	public GameObject llave;
	public GameObject pocion;

	private void Start(){
		llave.SetActive(false);
		pocion.SetActive(false);
	}

	private void Update(){
		if(tengoLlave == true){
			llave.SetActive(true);
		}
	}

}
