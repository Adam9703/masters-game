using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashTest : MonoBehaviour
{
    public GameObject cam; // Player is the camera in 2D game

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // get component finds the script, allows you to call functions from other script
            cam.GetComponent<CashHandler>().addCash(5);
        }
        if (Input.GetMouseButtonDown(2))
        {
            cam.GetComponent<CashHandler>().subtractCash(5);
        }
        
    }
}
