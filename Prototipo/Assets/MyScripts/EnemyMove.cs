using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Vector3 finalPosition;
    public float speed;
    public int flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
        int lane = Random.Range(1, 5);
        transform.position= new Vector3(18, 2.5f, lane);
        finalPosition = new Vector3(-1, 2.5f, lane);
    }

    // Update is called once per frame
    void Update()
    {
        if (flag==0)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, finalPosition, step);
            if (transform.position==finalPosition)
            {
                flag = 1;
            }
        }
        else
        {
            int lane = Random.Range(1, 5);
            transform.position = new Vector3(18, 2.5f, lane);
            finalPosition = new Vector3(-1, 2.5f, lane);
            flag = 0;
        }
    }
}
