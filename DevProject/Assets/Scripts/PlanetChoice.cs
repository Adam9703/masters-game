using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetChoice : MonoBehaviour
{
    public GameObject RedPlanet;
    public GameObject YellowPlanet;
    public GameObject EarthPlanet;
    public int PlanetImport;

    // Start is called before the first frame update
    void Start()
    {
        PlanetImport = GlobalPlanet.planetType;

        if (PlanetImport == 1)
        {
            EarthPlanet.SetActive(true);
        }
        if (PlanetImport == 2)
        {
            RedPlanet.SetActive(true);
        }
        if (PlanetImport == 3)
        {
            YellowPlanet.SetActive(true);
        }
    }
}
