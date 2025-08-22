using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3; // Start value
    public Renderer rend;
    private int limit;

    void Start()
    {
        // Nothing else needed here
        limit = Random.Range(150, 251);
    }

    void Update()
    {
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i == limit)
        {
            if (rend != null)
            {
                rend.enabled = false; // Disable the Renderer to hide the object
            }
        }
        
        i++; // Increment i at the start of every frame
        Debug.Log(gameObject.name + ":" + i); // Print with no spaces
    }
}
