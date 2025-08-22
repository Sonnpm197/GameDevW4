using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    
    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        // Limit framerate to 60 FPS
        Application.targetFrameRate = 60;
        // Instantiate redObj at (2.2, 0, 0) with no rotation
        Instantiate(redObj, new Vector3(2.2f, 0f, 0f), Quaternion.identity);

        // Instantiate blueObj at (-2.2, 0, 0) with no rotation
        Instantiate(blueObj, new Vector3(-2.2f, 0f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
