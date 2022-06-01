using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.1f);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.1f);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 1, 0);
        }

        if(transform.position.y < -5)
        {
            transform.position = new Vector3(11, 0.5f, 0.2f);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Obstaculo1")
        {

            transform.position = new Vector3(11, 0.5f, 0.2f);
        }

    }
}
