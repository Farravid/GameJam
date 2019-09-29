using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoInicio : MonoBehaviour
{
    public Text inicio;
    // Start is called before the first frame update
    void Start()
    {
        inicio.gameObject.SetActive(false);
        StartCoroutine(Muestra());
    }

    public IEnumerator Muestra()
    {
        inicio.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        inicio.gameObject.SetActive(false);
    }
}
