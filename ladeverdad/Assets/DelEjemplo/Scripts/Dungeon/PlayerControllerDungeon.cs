using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerDungeon : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed = 0.5f;
    private SpriteRenderer sp;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal") * moveSpeed;
        moveV = Input.GetAxisRaw("Vertical") * moveSpeed;

        if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            sp.flipX = false;
        }
        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            sp.flipX = true;
        }

        if (Input.GetKeyDown("r"))
        {
            Enemy.listo = true;
            SceneManager.LoadScene("SampleScene");
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV);

    }
}
