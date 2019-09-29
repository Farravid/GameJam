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

    //public CharacterController control;


    void Start()
    {
        textUI.gameObject.SetActive(false);
        textoFlotante.gameObject.SetActive(false);
        estaEnElArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && estaEnElArea)
        {
            textoFlotante.gameObject.SetActive(false);
            npcTalk();
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
            Debug.Log("BB");
            textoFlotante.gameObject.SetActive(false);
        }
    }

    public void npcResume()
    {
        textUI.gameObject.SetActive(true);
        //Time.timeScale = 1f;
        npcIsTalking = false;

    }
    void npcTalk()
    {
        textUI.gameObject.SetActive(true);
        //Time.timeScale = 0f;
        npcIsTalking = true;
    }
}
