using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Intro : MonoBehaviour
    
{
    public GameObject bruja;
    public Text bolaText;
    // Start is called before the first frame update
    void Start()
    {
        bruja.SetActive(false);
        bolaText.gameObject.SetActive(false);
        StartCoroutine(espera());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator espera()
    {
        yield return new WaitForSeconds(4);
        bolaText.gameObject.SetActive(true);
        bruja.SetActive(true);
        
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("SampleScene");
    }
}
