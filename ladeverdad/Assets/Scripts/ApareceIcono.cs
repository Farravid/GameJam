using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApareceIcono : MonoBehaviour
{
    public GameObject player;
    public GameObject exclama;
    public Text texto;
    private bool dentro;
    // Start is called before the first frame update
    void Start()
    {
        exclama.SetActive(false);
        texto.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dentro)
        {
            exclama.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                texto.gameObject.SetActive(true);
            }
        }
        else
        {
            exclama.SetActive(false);
            texto.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            dentro = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            dentro = false;
        }
    }
}
