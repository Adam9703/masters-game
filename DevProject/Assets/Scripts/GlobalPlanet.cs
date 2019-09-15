using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPlanet : MonoBehaviour
{
    public static int planetType;
    public GameObject EnterButton;

    public void EarthPlanet()
    {
        planetType = 1;
        EnterButton.SetActive(true);
    }

    public void RedPlanet()
    {
        planetType = 2;
        EnterButton.SetActive(true);
    }

    public void YellowPlanet()
    {
        planetType = 3;
        EnterButton.SetActive(true);
    }
}
