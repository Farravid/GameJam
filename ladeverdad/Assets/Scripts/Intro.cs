using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(espera());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator espera()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("SampleScene");
    }
}
