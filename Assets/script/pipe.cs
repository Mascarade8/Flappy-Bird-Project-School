using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-0.008f, 0f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            //BAM BAM
            // Kill The Player
            collision.gameObject.SetActive(false);

        }
    }
}
