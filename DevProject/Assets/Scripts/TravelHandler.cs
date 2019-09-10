using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TravelHandler : MonoBehaviour
{
    public void TravelMars()
    {
        SceneManager.LoadScene("Level2");
    }
}
