using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    [SerializeField] private float lifeTimer;

    private void Start()
    {
        Destroy(gameObject, lifeTimer);

    }

}
