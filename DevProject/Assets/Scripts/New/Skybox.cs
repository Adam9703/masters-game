using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour
{
    public Material backgroundOne;
    public Material backgroundTwo;
    public Material backgroundThree;
    public Material backgroundFour;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = backgroundOne; // The default skybox when the game is loaded
    }
    
    // Below each function changes the skybox to a new material
    // This is triggered on button click, e.g. the player clicks travel to mars then
    // the mars skybox is loaded
    public void MarsSky()
    {
        RenderSettings.skybox = backgroundTwo;
    }

    public void SaturnSky()
    {
        RenderSettings.skybox = backgroundThree;
    }

    public void TravelSky()
    {
        RenderSettings.skybox = backgroundFour;
    }

    public void MainSky()
    {
        RenderSettings.skybox = backgroundOne;
    }
}
