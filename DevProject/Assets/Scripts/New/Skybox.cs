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
        RenderSettings.skybox = backgroundOne;
    }
    
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
