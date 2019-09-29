using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Finalizar : MonoBehaviour
{
    public Text fin;

    void Start()
    {
        fin.gameObject.SetActive(false);
    }

    void Update()
    {
        if (TalkNPC.hablado)
        {
            StartCoroutine(irse());
        }
    }
    public IEnumerator irse()
    {
        yield return new WaitForSeconds(7);
        fin.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuPrincipal");
    }
}
