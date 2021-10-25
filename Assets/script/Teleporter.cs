using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public float c_initTPValue_X;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.GetComponent<pipe>() != null)
        {
            pipe f_pipe = collision.GetComponent<pipe>();
            f_pipe.transform.position = new Vector3(c_initTPValue_X, f_pipe.transform.position.y, 0f);
            //teleport
        }
    }
}
