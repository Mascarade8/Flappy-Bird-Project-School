using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManage gameManage;
    public float velocity = 1;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D f_rigid = GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManage.GameOver();

    }
}
