using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Texture2D mainTexture;
    public Texture2D replacementTexture;
    private int flag;

    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (flag==0)
            {
                GetComponent<Renderer>().material.mainTexture = replacementTexture;
                flag = 1;
            }
            else
            {
                GetComponent<Renderer>().material.mainTexture = mainTexture;
                flag = 0;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            flag = 0;
            GetComponent<Renderer>().material.mainTexture = mainTexture;
        }
    }
}
