using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform wayPoint01, wayPoint02;
    private Transform wayPointTarget;
    [SerializeField] private float attackRange;
    [SerializeField] private float moveSpeed;
    private SpriteRenderer sp;
    private Transform target;
    public GameObject projectile;
    public static bool listo;

    // Start is called before the first frame update
    void Start()
    {
        listo = true;
        wayPointTarget = wayPoint01;
        sp = GetComponent<SpriteRenderer>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) >= attackRange)
        {
            Patrol();
        }
        else if ( listo )
        {
            Shoot();
        }
        
    }

    private void Patrol()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPointTarget.position, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, wayPoint01.position) <= 0.01f)
        {
            wayPointTarget = wayPoint02;
            sp.flipX = false;
        }

        if (Vector2.Distance(transform.position, wayPoint02.position) <= 0.01f)
        {
            wayPointTarget = wayPoint01;
            sp.flipX = true;
        }
    }

    public void Shoot()
    {
        listo = false;
        Instantiate(projectile, transform.position, Quaternion.identity);
    }


}
