using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float c_thurst;
    public float c_maxSpeedY_Up;
    public float c_maxSpeedY_Down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D f_rigid = GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("add force");
            //GetComponent<Rigidbody2D>().AddForce(Vector2.up * c_thurst, ForceMode2D.Force);
            
            f_rigid.AddForce(Vector2.up * c_thurst, ForceMode2D.Force);
        }

            if( f_rigid.velocity.y > c_maxSpeedY_Up)
            {
                f_rigid.velocity = new Vector2(0f, c_maxSpeedY_Up);
            }

            if( f_rigid.velocity.y < -c_maxSpeedY_Down)
            {
                f_rigid.velocity = new Vector2(0f, -c_maxSpeedY_Down);
            }
        
    }
}
