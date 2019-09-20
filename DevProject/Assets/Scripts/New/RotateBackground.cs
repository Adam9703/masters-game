using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackground : MonoBehaviour
{
    public float rotateSpeed = 1.1f; // Default rotate speed
    
    // Update is called once per frame
    void Update()
    {
        // Set the speed of the rotate to update at the beginning of a frame and multiply by rotatespeed
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed); 
    }
    
}
