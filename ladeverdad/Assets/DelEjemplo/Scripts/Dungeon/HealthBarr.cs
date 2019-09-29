using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBarr : MonoBehaviour
{
    public Image hpImage;
    public Image hpEffectImage;
    [SerializeField] public float hp;
    [SerializeField] private float maxHp;
    [SerializeField] private float hurtSpeed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        hpImage.fillAmount = hp / maxHp;

        if (hpEffectImage.fillAmount > hpImage.fillAmount)
        {
            hpEffectImage.fillAmount -= hurtSpeed;
        }
        else
        {
            hpEffectImage.fillAmount = hpImage.fillAmount;
        }

        if (hp == 0 && this.gameObject.tag == "Player")
        {
            Enemy.listo = true;
            SceneManager.LoadScene("Dungeon");
            Inventario.tengoLlave = false;
        }
        else if ( hp==0 ) 
        {
            Destroy(this.gameObject);
        }
    }

}
