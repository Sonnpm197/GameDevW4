using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i = 3; // Start value

    void Start()
    {
        // Nothing else needed here
    }

    void Update()
    {
        i++; // Increment i at the start of every frame
        Debug.Log(gameObject.name + ":" + i); // Print with no spaces
    }
}
