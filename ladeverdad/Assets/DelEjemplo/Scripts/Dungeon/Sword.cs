using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float moveSpeed;

    private float lifeTimer;
    [SerializeField] private float maxLife = 2.0f;

    public GameObject destroyEffect;
    public GameObject attackEffect;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        lifeTimer += Time.deltaTime;
        if (lifeTimer >= maxLife)
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Enemy.listo = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            other.GetComponentInChildren<HealthBarr>().hp -= 25;
            Instantiate(attackEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Enemy.listo = true;
         }
    }
}
