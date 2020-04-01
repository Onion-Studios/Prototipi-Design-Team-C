using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayActivate());
    }

    // Update is called once per frame
    IEnumerator DelayActivate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
            yield return new WaitForSeconds(2);
        }
    }
}
