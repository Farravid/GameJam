using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Image black;
    public Animator anim;
    public void PlayGame()
    {
      StartCoroutine(Fading());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator Fading()
    {
        anim.SetBool("anim", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene("SampleScene");
    }
}
