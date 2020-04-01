using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Signs : MonoBehaviour
{
    private string[] Sign1 = new string[]{"d", "w", "w", "a", "space"};
    private string[] Sign1Variant = new string[] { "d", "s", "s", "a", "space"};
    private string[] Sign2 = new string[] { "a", "w", "w", "d", "space"};
    private string[] Sign2Variant = new string[] { "a", "s", "s", "d", "space"};
    private string[] Sign3 = new string[] { "a", "a", "w", "w", "space"};
    private string[] Sign3Variant = new string[] { "s", "s", "d", "d", "space"};
    private string[] Sign4 = new string[] { "d", "d", "w", "w", "space"};
    private string[] Sign4Variant = new string[] { "s", "s", "a", "a", "space"};
    private string[] Sign5 = new string[] { "a", "s", "a", "s", "space"};
    private string[] Sign5Variant = new string[] { "w", "d", "w", "d", "space"};
    private string[] Sign6 = new string[] { "d", "s", "d", "s", "space"};
    private string[] Sign6Variant = new string[] { "w", "a", "w", "a", "space"};
    private string[] takeValues = new string[]{"","","","",""};
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (i<=4)
        {
            if (Input.GetKeyDown("w"))
            {
                takeValues[i] = "w";
                i += 1;
            }
            if (Input.GetKeyDown("a"))
            {
                takeValues[i] = "a";
                i += 1;
            }
            if (Input.GetKeyDown("s"))
            {
                takeValues[i] = "s";
                i += 1;
            }
            if (Input.GetKeyDown("d"))
            {
                takeValues[i] = "d";
                i += 1;
            }
            if (Input.GetKeyDown("space"))
            {
                takeValues[i] = "space";
                i = 0;
                if (takeValues.SequenceEqual(Sign1) || takeValues.SequenceEqual(Sign1Variant))
                {
                    Debug.Log("Segno 1");
                }
                else if (takeValues.SequenceEqual(Sign2) || takeValues.SequenceEqual(Sign2Variant))
                {
                    Debug.Log("Segno 2");
                }
                else if (takeValues.SequenceEqual(Sign3) || takeValues.SequenceEqual(Sign3Variant))
                {
                    Debug.Log("Segno 3");
                }
                else if (takeValues.SequenceEqual(Sign4) || takeValues.SequenceEqual(Sign4Variant))
                {
                    Debug.Log("Segno 4");
                }
                else if (takeValues.SequenceEqual(Sign5) || takeValues.SequenceEqual(Sign5Variant))
                {
                    Debug.Log("Segno 5");
                }
                else if (takeValues.SequenceEqual(Sign6) || takeValues.SequenceEqual(Sign6Variant))
                {
                    Debug.Log("Segno 6");
                }
                else
                {
                    Debug.Log("Segno errato");
                }
            }
        }
        else
        {
            i = 0;
        }
    }
}