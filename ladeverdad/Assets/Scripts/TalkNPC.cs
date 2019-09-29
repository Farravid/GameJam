using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkNPC : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textUI;
    public static bool npcIsTalking = false;
    public bool estaEnElArea = false;
    public Text textoFlotante;
    private bool hablado;
    //public CharacterController control;


    void Start()
    {
        textUI.gameObject.SetActive(false);
        textoFlotante.gameObject.SetActive(false);
        estaEnElArea = false;
        hablado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && estaEnElArea)
        {
            textoFlotante.gameObject.SetActive(false);
            StartCoroutine(npcTalk());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            //CharacterController cc = collision.GetComponent<CharacterController>();
            //cc.enabled = false;
            estaEnElArea = true;
            textoFlotante.gameObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            textUI.gameObject.SetActive(false);
            npcIsTalking = false;
            estaEnElArea = false;
            textoFlotante.gameObject.SetActive(false);
        }
    }

    public void npcResume()
    {
        textUI.gameObject.SetActive(true);
        //Time.timeScale = 1f;
        npcIsTalking = false;

    }
    public IEnumerator npcTalk()
    {
        textUI.gameObject.SetActive(true);
        //Time.timeScale = 0f;
        npcIsTalking = true;
        if (hablado == false) {
            hablado = true;
            IsometricPlayerMovementController.movementSpeed = 0f;
            yield return new WaitForSeconds(5);
            IsometricPlayerMovementController.movementSpeed = 2.8f;
        }
    }
}
