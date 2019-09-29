using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cartel : MonoBehaviour
{
    public Text interact;
    private bool dentro;
    //public GameObject canvashostia;
    private void Start()
    {
        interact.gameObject.SetActive(false);
        dentro = false;
    }
    private void Update()
    {

        if (PauseMenu.GameIsPaused)
        {
            interact.gameObject.SetActive(false);
        }
        else if (PauseMenu.GameIsPaused == false && dentro)
        {
            interact.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && dentro)
        {
            interact.gameObject.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            interact.gameObject.SetActive(true);
            dentro = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            interact.gameObject.SetActive(false);
            dentro = false;
        }
    }
}
