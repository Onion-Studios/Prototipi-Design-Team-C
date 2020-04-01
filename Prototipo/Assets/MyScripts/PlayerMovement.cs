using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            if (transform.position.z != 4)
            transform.position = transform.position + new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown("s"))
        {
            if (transform.position.z != 0)
            transform.position = transform.position + new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown("a"))
        {
            if (transform.position.x != 0)
            transform.position = transform.position + new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            if (transform.position.x != 4)
            transform.position = transform.position + new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            transform.position = new Vector3(2, 2.5f, 2);
        }
    }
}
