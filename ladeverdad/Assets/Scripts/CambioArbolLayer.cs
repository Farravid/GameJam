using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioArbolLayer : MonoBehaviour
{
    public GameObject player;
    public GameObject arbol;
    float yArbol;
    float yPlayer;
    private SpriteRenderer spriteArbol;

    // Start is called before the first frame update
    // Update is called once per frame

    void Update()
    {
        yArbol = arbol.transform.position.y;
        yPlayer = player.transform.position.y;
        spriteArbol = arbol.GetComponent<SpriteRenderer>();
        if(yArbol < yPlayer)
        {
            spriteArbol.sortingOrder = 6; 
        }
        else if(yPlayer < yArbol)
        {
            spriteArbol.sortingOrder = 2;
        }
    }
}
