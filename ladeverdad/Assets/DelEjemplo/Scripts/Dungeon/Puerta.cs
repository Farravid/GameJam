using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    [SerializeField] private Text exitText;
    private bool exitScene;
    public Text faltaLlave;
    public Vector2 theposition;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        exitText.gameObject.SetActive(false);
        exitScene = false;
        faltaLlave.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (exitScene && Input.GetKeyDown(KeyCode.E))
        {
            if (Inventario.tengoLlave)
            {

                SceneManager.LoadScene("SalidaDungeon");
            }
            else
            {
                exitText.gameObject.SetActive(false);
                faltaLlave.gameObject.SetActive(true);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            exitText.gameObject.SetActive(true);
            exitScene = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            exitScene = false;
            exitText.gameObject.SetActive(false);
            faltaLlave.gameObject.SetActive(false);
        }
    }

}
